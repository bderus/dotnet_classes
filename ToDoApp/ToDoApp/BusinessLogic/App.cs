using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.BusinessLogic.Controllers;
using ToDoApp.UI;

namespace ToDoApp.BusinessLogic
{
    internal class App
    {
        private ToDoListController ToDoListController { get; set; }

        public App()
        {
            ToDoListController = new ToDoListController();
        }

        public void StartApp()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            while (true)
            {
                var userAnswer = ConsoleMenu.PrintMainMenu();

                if (userAnswer == "3")
                    return;
                if (userAnswer == "2")
                    AddNewList();

                ShowToDoLists();
            }
        }

        private void AddNewList()
        {
            var newListName = ConsoleMenu.PrintGetName();
            ToDoListController.AddNewList(newListName);
        }

        private void ShowToDoLists()
        {
            var toDoLists = ToDoListController.ToDoLists;
            var mainMenuOption = (toDoLists.Count + 1).ToString();

            var userAnswer = ConsoleMenu.PrintToDoListsMenu(toDoLists);

            if (userAnswer == mainMenuOption)
                return;
         
            var selectedListId = int.Parse(userAnswer);

            ShowListItems(selectedListId);
        }

        private void ShowListItems(int selectedListId)
        {
            var itemsList = ToDoListController.GetListItems(selectedListId);
            var userAnswer = ConsoleMenu.PrintToDoItemsMenu(itemsList);

            if (userAnswer == "2")
                return;

            AddNewToDoItem(selectedListId);
        }

        private void AddNewToDoItem(int selectedListId)
        {
            var newItemName = ConsoleMenu.PrintGetName();
            ToDoListController.AddItemToList(selectedListId, newItemName);

            ShowListItems(selectedListId);
        }
    }
}
