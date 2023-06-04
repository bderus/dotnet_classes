using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace FileOperation.ExcelFiles
{
    internal class ExcelOperation
    {
        private FileOperation FileOperation { get; set; } = new FileOperation();

        private const string filePath1 = "C:\\Users\\yomos\\Desktop\\A.txt";
        private const string filePath2 = "C:\\Users\\yomos\\Desktop\\B.txt";
        public void GenereteExcelFile(string input1, string input2)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var firstFileRows = FileOperation.GetRowsFromFile(filePath1);
            var secondFileRows = FileOperation.GetRowsFromFile(filePath2);

            using (var package = new ExcelPackage())
            {
                var sheet1 = package.Workbook.Worksheets.Add("SpreadSheet1");

                for (var i = 0; i < firstFileRows.Length; i++)
                {
                    sheet1.Cells[$"A{i+1}"].Value = firstFileRows[i];
                    sheet1.Cells[$"A{i+1}"].Style.WrapText = true;
                }

                var sheet2 = package.Workbook.Worksheets.Add("SpreadSheet2");

                for (var i = 0; i < secondFileRows.Length; i++)
                {
                    sheet2.Cells[$"A{i+1}"].Value = secondFileRows[i];
                    sheet2.Cells[$"A{i+1}"].Style.WrapText = true;
                }

                package.SaveAs(new FileInfo("C:\\Users\\yomos\\Desktop\\output.xlsx"));
            }

        }
    }
}
