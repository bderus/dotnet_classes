using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.BusinessLogic;

namespace ToDoApp.UI
{
    internal static class ConsoleMenu
    {


        public static string PrintMainMenu()
       
        {
            Console.Clear();

            var possibleOptions = 2;

            Console.WriteLine("Welcome to ToDoApp!");
            Console.WriteLine("1. Please implement me!");            
            Console.WriteLine("2. Exit app");
            Console.WriteLine("Please select one of the options (1-2): ");

            return GetUserAnswer(possibleOptions);
        }

        private static string GetUserAnswer(int possibleOptions)
        {
            var possibleOptionList = new List<string>();

            for (var i = 1; i <= possibleOptions; i++)
            {
                possibleOptionList.Add(i.ToString());
            }

            while (true)
            {
                var userAnswer = Console.ReadLine();

                if (possibleOptionList.Contains(userAnswer))
                    return userAnswer;

                PrintTryAgainErrorMessage(userAnswer);
            }
        }

        private static void PrintTryAgainErrorMessage(string userInput)
        {
            Console.WriteLine($"Wrong input: {userInput}, please try again: ");
        }
    }
}
