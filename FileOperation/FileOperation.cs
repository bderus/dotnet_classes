using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace FileOperation
{
    internal class FileOperation
    {
        public string DefaultPath { get; set; } = "C:\\Users\\piotr\\OneDrive\\Pulpit";
        public string FileName { get; set; } = "transport<COBDATE>.csv";


        public void RollFile(string cobDate)
        {
            var previousCobDate = GetPreviousCobDate(cobDate);
            var destPath = Path.Combine(DefaultPath, FileName.Replace("<COBDATE>", cobDate));
            var sourcePath = Path.Combine(DefaultPath, FileName.Replace("<COBDATE>", previousCobDate));
            File.Copy(sourcePath, destPath);
        }
        public string GetPreviousCobDate(string cobDate)
        {
            var cobDateToDateTimeMinusOne = DateTime.ParseExact(cobDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(-1);

            return cobDateToDateTimeMinusOne.ToString("yyyyMMdd");
        }

        public bool CheckIfDestFileExist(string destFilePath)
        {
            if (File.Exists(destFilePath))
            {
                Console.WriteLine("Plik o tej nazwie juz istnieje");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CopyFile(string path, string destFilePath)
        {
            if (CheckIfDestFileExist(destFilePath))
            {
                File.Copy(path, destFilePath);
                Console.WriteLine("Plik został skopionowany");
            }
           
        }

    }
}
