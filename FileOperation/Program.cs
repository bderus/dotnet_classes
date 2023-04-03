using System;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var rollFile = new FileOperation();
            rollFile.SetNewValueForElement("20230403", "C:\\Users\\yomos\\Desktop\\transport20230402.csv");
            //rollFile.RollFile(args[0]);
        }
    }
}
