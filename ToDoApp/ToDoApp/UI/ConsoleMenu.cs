using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.UI
{
    internal static class ConsoleMenu
    {
        public static string PrintMainMenu()
        {
            Console.Clear();

            var possibleOptions = 3;

            Console.WriteLine("Welcome to ToDoApp!");
            Console.WriteLine("1. Show my ToDo Lists");
            Console.WriteLine("2. Add new ToDo Lists");
            Console.WriteLine("3. Exit app");
            Console.WriteLine("Please select one of the options (1-3): ");

            return GetUserAnswer(possibleOptions);
        }

        public static string PrintToDoListsMenu(List<string> toDoLists)
        {
            Console.Clear();

            var listCount = toDoLists.Count;
            var lastOption = listCount + 1;
            var mainMenuOption = lastOption.ToString();

            if (listCount == 0){
                Console.WriteLine("You don't have any list!");

                return mainMenuOption;
            }

            Console.WriteLine("Below you can find your ToDo Lists");

            for(var i = 0; i < listCount; i++) 
                Console.WriteLine($"{i+1}. {toDoLists[i]}");

            Console.WriteLine($"{lastOption}. Back to Main Menu");
            Console.WriteLine($"Please select one of the options (1-{mainMenuOption}): ");

            return GetUserAnswer(lastOption);
        }

        public static string PrintToDoItemsMenu(List<string> toDoItems)
        {
            Console.Clear();

            Console.WriteLine("Below you can find your ToDo Items");

            foreach (var toDoItem in toDoItems)
            {
                Console.WriteLine($"[ ] {toDoItem}");
            }

            Console.WriteLine("1. Back to Main Menu");
            Console.WriteLine("Please type 1 to go back to Main Menu: ");

            return GetUserAnswer(1);
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
