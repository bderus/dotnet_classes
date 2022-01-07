using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.UI;
using ToDoApp.Models;
using ToDoApp.BusinessLogic.Controllers;

namespace ToDoApp.BusinessLogic
{
    internal class App
    {
        private List<string> ToDoLists { get; set; }
        private Dictionary<int, List<string>> ToDoItemsDict { get; set; }
        private ToDoListController ToDoListController { get; set; }

        public App()
        {
            ToDoLists = new List<string>();
            ToDoItemsDict = new Dictionary<int, List<string>>();
            ToDoListController = new ToDoListController();
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

                if (userAnswer == "3")
                    return;

                if (userAnswer == "1")
                    ShowToDoLists();

                if (userAnswer == "2")
                    AddNewListToDoList();
            }
        }

        private void ShowToDoLists()
        {
            var mainMenuOption = (ToDoListController.ToDoLists.Count + 1).ToString();

            var userAnswer = ConsoleMenu.PrintToDoListsMenu(ToDoListController.ToDoLists);

            if (userAnswer == mainMenuOption)
                return;
         
            var selectedListId = int.Parse(userAnswer);

            ShowListItems(selectedListId);
        }
        private void AddNewListToDoList()
        {
            Console.WriteLine("Provide the name of the list: ");

            var userAnswer = Console.ReadLine();

            ToDoListController.CreateNewToDoList(userAnswer);
        }
        private void ShowListItems(int selectedListId)
        {
            var itemsList = ToDoListController.GetListItems(selectedListId);
            var userAnswer = ConsoleMenu.PrintToDoItemsMenu(itemsList);

            if (userAnswer == "1")
                AddNewItemToDoList(selectedListId);

            if (userAnswer == "2")
                return;
        }
        private void AddNewItemToDoList(int selectedListId)
        {
            Console.WriteLine("Provide the name of the item: ");

            var userAnswer = Console.ReadLine();

            ToDoListController.AddNewItemToList(selectedListId, userAnswer);
        }
    }
}
