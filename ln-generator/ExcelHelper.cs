using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln_generator
{
    public class ExcelHelper
    {
        public static int readExcelWorksheetIntValue(Worksheet ws, int rowIndex, int colIndex, string error)
        {
            int res;
            object o = ws.Cells[rowIndex, colIndex].Value;
            if (null != o && int.TryParse(o.ToString(), out res))
            {
                return res;
            }
            else
            {
                MessageBox.Show(error, "Bad Format",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ApplicationException(error);
            }
        }

        public static double readExcelWorksheetDoubleValue(Worksheet ws, int rowIndex, int colIndex, string error)
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

        public static string readExcelWorksheetStringValue(Worksheet ws, int rowIndex, int colIndex, string error)
        {
            string value = readExcelWorksheetStringValue(ws, rowIndex, colIndex);
            if (0 == value.Length)
            {
                MessageBox.Show(error, "Bad Format",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ApplicationException(error);
            }
            else
            {
                return value;
            }
        }

        public static string readExcelWorksheetStringValue(Worksheet ws, int rowIndex, int colIndex)
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

        public static int ColumnLetterToColumnIndex(string columnLetter)
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
}
