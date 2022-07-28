using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ln_generator
{
    public class Config
    {
        private static Config instance = new Config();

        public static Config getInstance()
        {
            return instance;
        }

        private BackgroundWorker bw = new BackgroundWorker();

        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        public Dictionary<string, Employee> GetEmployeesConfig() { return new Dictionary<string, Employee>(this.employees); }

        public string PONumber { get; private set; }

        public int Year { get; private set; }

        private int FirstDataRowIndex { get; set; }
        private int EmployeeColumnIndex { get; set; }

        private List<MonthConfig> monthConfigs = new List<MonthConfig>();

        public List<MonthConfig> GetMonthConfigs() { return new List<MonthConfig>(monthConfigs); }

        public void Init(String filename, BackgroundWorker bw)
        {
            this.bw = bw;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = null;
            try
            {
                wb = excel.Workbooks.Open(filename);
                if (!isFileCorrect(wb))  return;
                bw.ReportProgress(0, "Loading Config");
                loadConfig(wb.Worksheets.Item["Config"]);
                bw.ReportProgress(0, "Loading Tracker");
                loadMain(wb.Worksheets.Item["Tracker"]);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error while working with Availability Tracker", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            finally
            {
                if (null != wb)
                {
                    wb.Close(false);
                }
                excel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            }
        }

        private void loadMain(Worksheet ws)
        {
            object o = ws.Cells[1, 2].Value;
            if (null == o)
                return;
            string poNum = o.ToString();
            if (string.IsNullOrEmpty(poNum))
                return;
            this.PONumber = poNum;

            this.Year = readExcelWorksheetIntValue(ws, 2, 2, "Year should be given in the cell B2 of the worksheet 'Tracker'");
            bw.ReportProgress(0, "Loading employee data...");
            loadEmployees(ws);
        }

        private void loadEmployees(Worksheet ws)
        {
            this.employees.Clear();
            for (int i = FirstDataRowIndex; i < 200000 ; i++)
            {
                string employee = readWorksheetStringValue(ws, i, 1);
                bw.ReportProgress(0, "Loading employee data - " + employee);
                if (string.IsNullOrEmpty(employee)) break;
                Employee e = new Employee();
                e.Name = employee;
                loadEmployeeMonths(ws, e, i, monthConfigs);
                this.employees.Add(employee, e);
            }

        }

        private void loadEmployeeMonths(Worksheet ws, Employee e, int employeeRow, List<MonthConfig> months)
        {
            Dictionary<string, EmployeeMonth> eMonths = new Dictionary<string, EmployeeMonth>();

            foreach (MonthConfig m in months)
            {
                bw.ReportProgress(0, "Loading employee data - " + e.Name + ", month " + m.Month);
                EmployeeMonth em = new EmployeeMonth();
                em.Month = m.Month;
                Dictionary<int, double> workingdays = new Dictionary<int, double>(31);
                for (int colIndex = m.StartColumn; colIndex <= m.EndColumn; colIndex++)
                {
                    String dayOfWeek = readExcelWorksheetStringValue(ws, 4, colIndex);
                    //satarday and sunday - non-working days
                    if (dayOfWeek.ToLower().StartsWith("sat") || dayOfWeek.ToLower().StartsWith("sun")) continue;
                    int day = readExcelWorksheetIntValue(ws, 3, colIndex, 
                        String.Format("Cannot read day number in the row [{0}] and column [{1}]", 3, colIndex));
                    
                    double w = readExcelWorksheetDoubleValue(ws, employeeRow, colIndex,
                        String.Format("Cannot read value in the row [{0}] and column [{1}]", employeeRow, colIndex));
                    double hours = w * 8;
                    workingdays.Add(day, hours);
                }
                em.setWorkDays(workingdays);
                eMonths.Add(m.Month, em);
            }
            e.setEmployeeMonth(eMonths);
        }

        private string readWorksheetStringValue(Worksheet ws, int rowIndex, int colIndex)
        {
            object o = ws.Cells[rowIndex, colIndex].Value;
            if (null == o) return "";
            return o.ToString();
        }

        private bool isFileCorrect(Workbook wb)
        {
            List<String> worksheetNames = new List<String>();
            foreach (Worksheet sheet in wb.Worksheets)
            {
                worksheetNames.Add(sheet.Name);
            }
            if (worksheetNames.Contains("Config") && worksheetNames.Contains("Tracker"))
            {
                return true;
            } 
            else
            {
                MessageBox.Show("File does not contain either of sheets: 'Config' or 'Tracker'.", "Availability Tracker Bad Format", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void loadConfig(Worksheet ws)
        {
            this.FirstDataRowIndex = readExcelWorksheetIntValue(ws, 2, 1, 
                "Tab Config should have integer value in the cell A2 which represents the first data row on the Tracker worksheet");
            this.EmployeeColumnIndex = readExcelWorksheetIntValue(ws, 2, 7,
                "Tab Config should have integer value in the cell G2 which represents the Employee Name column index on the Tracker worksheet");
            this.monthConfigs = readMonths(ws);
        }

        private List<MonthConfig> readMonths(Worksheet ws)
        {
            List<MonthConfig> monthConfigs = new List<MonthConfig>();
            object o;
            int rowIndex = 2;
            while (true)
            {
                o = ws.Cells[rowIndex, 3].Value;
                if (null == o)
                    break;
                string monthName = o.ToString();
                if (string.IsNullOrEmpty(monthName))
                    break;
                int monthStartColumnIndex = 0;
                o = ws.Cells[rowIndex, 4].Value;

                if (null != o)
                {
                    monthStartColumnIndex = ColumnLetterToColumnIndex(o.ToString());
                }
                else
                {
                    MessageBox.Show("Tab Config should have start column name next to month name for month " + monthName,
                        "Availability Tracker Bad Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                int monthEndColumnIndex = 0;
                o = ws.Cells[rowIndex, 5].Value;
                if (null != o)
                {
                    monthEndColumnIndex = ColumnLetterToColumnIndex(o.ToString()); 
                }
                else
                {
                    MessageBox.Show("Tab Config should have end column name next to month name for month " + monthName,
                        "Availability Tracker Bad Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break; 
                }
                if (!String.IsNullOrEmpty(monthName) && monthStartColumnIndex > 0 && monthEndColumnIndex > 0)
                {
                    MonthConfig mc = new MonthConfig();
                    mc.Month = monthName;
                    mc.StartColumn = monthStartColumnIndex;
                    mc.EndColumn = monthEndColumnIndex;
                    monthConfigs.Add(mc);
                }
                else break;
                rowIndex++;
            }
            return monthConfigs;
        }

        private int readExcelWorksheetIntValue(Worksheet ws, int rowIndex, int colIndex, string error)
        {
            int res;
            object o = ws.Cells[rowIndex, colIndex].Value;
            if (null != o && int.TryParse(o.ToString(), out res))
            {
                return res;
            }
            else
            {
                MessageBox.Show(error, "Availability Tracker Bad Format", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ApplicationException(error);
            }
        }

        private double readExcelWorksheetDoubleValue(Worksheet ws, int rowIndex, int colIndex, string error)
        {
            double res;
            object o = ws.Cells[rowIndex, colIndex].Value;
            if (null != o && double.TryParse(o.ToString(), out res))
            {
                return res;
            }
            else
            {
                return 0;
            }
        }

        private string readExcelWorksheetStringValue(Worksheet ws, int rowIndex, int colIndex)
        {
            object o = ws.Cells[rowIndex, colIndex].Value;
            if (null != o)
            {
                return o.ToString();
            }
            else
            {
                return String.Empty;
            }
        }

        private int ColumnLetterToColumnIndex(string columnLetter)
        {
            if (String.IsNullOrEmpty(columnLetter)) return -1;
            columnLetter = columnLetter.ToUpper();
            int sum = 0;

            for (int i = 0; i < columnLetter.Length; i++)
            {
                sum *= 26;
                sum += (columnLetter[i] - 'A' + 1);
            }
            return sum;
        }
    }

    public class MonthConfig
    {
        public String Month { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
    }

    public class EmployeeMonth
    {
        public String Month { get; set; }

        private Dictionary<int, double> workDays = new Dictionary<int, double>();
        internal void setWorkDays(Dictionary<int, double> workDays) { this.workDays = workDays; }

        public Dictionary<int, double> getWorkingDays() { return new Dictionary<int, double>(workDays); }

    }

    public class Employee
    {
        public String Name { get; set; }

        private Dictionary<string, EmployeeMonth> months = new Dictionary<string, EmployeeMonth>();

        internal void setEmployeeMonth(Dictionary<string, EmployeeMonth> months) { this.months = months; }

        public Dictionary<string, EmployeeMonth> GetEmployeeMonths() { return new Dictionary<string, EmployeeMonth>(months); }
    }
}
