using System;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file = new FileOperation(args[0], args[1]);
            file.RollFile();
        }
    }
}
