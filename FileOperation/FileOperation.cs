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
        public string DefaultPath { get; set; } = "C:\\Users\\piotr\\OneDrive\\Pulpit";
        public string FileName { get; set; } = "transport<COBDATE>.csv";


        public void RollFile(string cobDate)
        {
            var previousCobDate = CobDateHelper.GetPreviousCobDate(cobDate);
            var destPath = Path.Combine(DefaultPath, FileName.Replace("<COBDATE>", cobDate));
            var sourcePath = Path.Combine(DefaultPath, FileName.Replace("<COBDATE>", previousCobDate));
            File.Copy(sourcePath, destPath);
        }



    }
}
