using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ln_generator
{
    internal class Generator
    {
        private string templateDefaultPath = "Properties\\Leistungsnachweis.xlsx";
        private BackgroundWorker bw;
        private int year;
        private List<string> months;
        private List<String> employees;
        private Config config;
        private string template;
        private string outputDir;
        private readonly int firstRowIndex = 18;
        private readonly int dateColumnIndex = 2;
        private readonly int hoursColumnIndex = 3;
        private readonly int totalDayRows = 23;
        private readonly int poRowIndex = 7;
        private readonly int poColumnIndex = 4;
        private readonly int nameRowIndex = 9;
        private readonly int nameColumnIndex = 4;
        private readonly int monthRowIndex = 5;
        private readonly int monthColumnIndex = 2;
        private readonly int yearRowIndex = 5;
        private readonly int yearColumnIndex = 3;

        private readonly Dictionary<string, int> monthsNum = new Dictionary<string, int>();
        private readonly Dictionary<string, Employee> employeesDict;

        private Generator() { }

        public Generator(BackgroundWorker bw, int year, List<string> months, 
            List<String> employees, Config config, string outputDir)
        {
            this.bw = bw;
            this.year = year;
            this.months = months;
            this.employees = employees;
            this.config = config;
            this.outputDir = outputDir;
            this.template = createTemplate();
            monthsNum.Add("January", 1);
            monthsNum.Add("February", 2);
            monthsNum.Add("March", 3);
            monthsNum.Add("April", 4);
            monthsNum.Add("May", 5);
            monthsNum.Add("June", 6);
            monthsNum.Add("July", 7);
            monthsNum.Add("August", 8);
            monthsNum.Add("September", 9);
            monthsNum.Add("October", 10);
            monthsNum.Add("November", 11);
            monthsNum.Add("December", 12);
            this.employeesDict = config.GetEmployeesConfig();
        }


        public void generate()
        {
            int totalSteps = employees.Count * months.Count;
            int currentStep = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                foreach (string month in months)
                {
                    String employee = employees[i];
                    bw.ReportProgress(currentStep++ * 100 / totalSteps, 
                        String.Format("Generating report for {0}; {1} out of {2}.", employee, i + 1, employees.Count));

                    Employee empData = employeesDict[employee];
                    Dictionary<string, EmployeeMonth> empMonthData = empData.GetEmployeeMonths();
                    EmployeeMonth monthData = empMonthData.GetValueOrDefault(month);
                    Dictionary<int, double> workingDays = monthData.getWorkingDays();
                    if (workingDays.Values.Sum() == 0) continue;

                    int monthNum = 0;
                    bool got = monthsNum.TryGetValue(month, out monthNum);
                    if (!got) throw new Exception("Wrong month: " + month);
                    string monthDir = String.Format("{0} - {1}", monthNum, month);
                    string outputDirFullPath = Path.Combine(outputDir, monthDir);
                    string outputFileFullPath = CopyTemplate(templateDefaultPath, outputDirFullPath, employee, month);
                    CopyData(outputFileFullPath, employee, month, workingDays);
                }
            }
        }

        private string CopyTemplate(string source, string outputDir, string employee, string month)
        {
            string targetFileName = String.Format("Leistungsnachweis_{0}_{1}_{2}.xlsx", month, year, employee);
            string target = Path.Combine(outputDir, targetFileName);
            Directory.CreateDirectory(outputDir);
            File.Copy(source, target, true);
            return target;
        }

        private void CopyData(string filename, string employee, string month, Dictionary<int, double> workingDays)
        {
            int monthNum = getMonthNum(month);
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Worksheet ws = null;
            Workbook wb = null;

            try
            {
                wb = excel.Workbooks.Open(filename);
                ws = wb.Worksheets.Item["Leistungsnachweis"];
                ws.Cells[poRowIndex, poColumnIndex].Value = config.PONumber;
                ws.Cells[nameRowIndex, nameColumnIndex].Value = employee;
                ws.Cells[monthRowIndex, monthColumnIndex].Value = month;
                ws.Cells[yearRowIndex, yearColumnIndex].Value = year;
                //Employee empData = employeesDict[employee];
                //Dictionary<string, EmployeeMonth> empMonthData = empData.GetEmployeeMonths();
                //EmployeeMonth monthData = empMonthData.GetValueOrDefault(month);
                //Dictionary<int, double> workingDays = monthData.getWorkingDays();
                int i = 0;
                foreach (var wd in workingDays)
                {
                    int day = wd.Key;
                    double hours = wd.Value;
                    string date = String.Format("{0,1:D2}.{1,1:D2}.{2}", day, monthNum, year);
                    ws.Cells[firstRowIndex + i, dateColumnIndex].Value = date;
                    ws.Cells[firstRowIndex + i, hoursColumnIndex].Value = hours;
                    i++;
                }
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
                    wb.Save();
                    wb.Close(true);
                }
                excel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            }
        }

        private int getMonthNum(string month)
        {
            return monthsNum.GetValueOrDefault(month, 0);
        }

        private string createTemplate()
        {
            if (!File.Exists(templateDefaultPath))
            {
                MessageBox.Show("Error: " + templateDefaultPath + " file is not found.");
            }
            return templateDefaultPath;
        }

        private void deleteTemplate()
        {
            if (File.Exists(template))
            {
                File.Delete(template);
            }
        }
    }
}
