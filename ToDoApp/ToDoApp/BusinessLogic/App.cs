using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.UI;

namespace ToDoApp.BusinessLogic
{
    internal class App
    {
        private List<string> ToDoLists { get; set; }
        private Dictionary<int, List<string>> ToDoItemsDict { get; set; }

        public App()
        {
            ToDoLists = new List<string>();
            ToDoItemsDict = new Dictionary<int, List<string>>();
        }

        public void StartApp()
        {
            AddTestItems();
            MainMenu();
        }

        private void AddTestItems()
        {
            for (var i = 1; i <= 3; i++)
            {
                var listName = $"Lista #{i}";
                ToDoLists.Add(listName);

                var toDoItems = new List<string> { $"{listName} - Item #1", $"{listName} - Item #2", $"{listName} - Item #3" };

                ToDoItemsDict.Add(i, toDoItems);

            }
        }

        private void MainMenu()
        {
            while (true)
            {
                var userAnswer = ConsoleMenu.PrintMainMenu();

                if (userAnswer == "2")
                    return;

                ShowToDoLists();
            }
        }

        private void ShowToDoLists()
        {
            var mainMenuOption = (ToDoLists.Count + 1).ToString();

            var userAnswer = ConsoleMenu.PrintToDoListsMenu(ToDoLists);

            if (userAnswer == mainMenuOption)
                return;
         
            var selectedListNumber = int.Parse(userAnswer);

            ShowListItems(selectedListNumber);
        }

        private void ShowListItems(int listNumber)
        {
            var itemsList = ToDoItemsDict[listNumber];
            var userAnswer = ConsoleMenu.PrintToDoItemsMenu(itemsList);

            if (userAnswer == "1")
                return;
        }
    }
}
