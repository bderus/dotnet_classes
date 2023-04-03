using System;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var rollFile = new FileOperation();
            rollFile.RollFile(args[0]);
        }
    }
}
