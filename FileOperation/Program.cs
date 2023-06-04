using System;
using System.IO;
using FileOperation.ExcelFiles;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file1 = File.ReadAllText("C:\\Users\\yomos\\Desktop\\A.txt");
            var file2 = File.ReadAllText("C:\\Users\\yomos\\Desktop\\B.txt");
            
            var excelOperation = new ExcelOperation();
            excelOperation.GenereteExcelFile(file1, file2);
            
            
            
            
            
            
            
            
            
            
            
            
            
            //var rollFile = new FileOperation();
            //rollFile.RollFile("20230403");
        }
    }
}
