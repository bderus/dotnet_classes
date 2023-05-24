using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using FileOperation.Helper;

namespace FileOperation
{
    internal class FileOperation
    {
        public string DefaultPath { get; set; } = "C:\\Users\\yomos\\Desktop";
        public string FileName { get; set; } = "transport<COBDATE>.csv";


        public void RollFile(string cobDate)
        {
            var convertedCobDate = CobDateHelper.ChangeCobDateFormat(cobDate);
            var previousCobDate = CobDateHelper.GetPreviousCobDate(cobDate);
            var destPath = Path.Combine(DefaultPath, FileName.Replace("<COBDATE>", cobDate));
            var sourcePath = Path.Combine(DefaultPath, FileName.Replace("<COBDATE>", previousCobDate));

            AppendTextToNewFile(convertedCobDate, destPath, sourcePath);
           
        }

        private string[] GetRowsFromFile(string sourcePath)
        {
            var readText = File.ReadAllText(sourcePath);

            string[] rows = readText.Split("\n");

            return rows;
        }
        private string RollingCobDate(string cobDate, string sourcePath)
        {
            var rows = GetRowsFromFile(sourcePath);
            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < rows.Length; i++)
            {
                var elements = rows[i].Split(",");
                if (i != 0)
                {
                    elements[0] = cobDate;                    
                }
                var k = 0;
                foreach (var element in elements)
                {                   
                    if (k < elements.Length - 1)
                    {
                        sb.Append(element + ",");
                    }
                    else
                    {
                        sb.Append(element);
                    }
                    k++;
                }
            }
            return sb.ToString();
        }

        public void AppendTextToNewFile(string cobDate, string destPath, string sourcePath)
        {
            var rolledCobDate = RollingCobDate(cobDate, sourcePath);
            using (var sw = File.AppendText(destPath))
            {
                sw.Write(rolledCobDate);
            }
        }
    }
}
