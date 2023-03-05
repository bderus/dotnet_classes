using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    internal static class ConsoleApp
    {
        public static void MainMenu(string path, string destFilePath)
        {
            Console.WriteLine("Witaj w aplikacji FileOperation!");
            Console.WriteLine("Wybierz jedną z poniższych opcji: ");
            Console.WriteLine("1. Kopiuj plik");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                var file = new FileOperation(path, destFilePath);
                file.RollFile(); 

            }
        }

    }
}
