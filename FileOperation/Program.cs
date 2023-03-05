using System;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new CommandLineParser();
            var argsParsed = parser.ArgumentParser(args);
            ConsoleApp.MainMenu(argsParsed[0], argsParsed[1]);           

        }
    }
}
