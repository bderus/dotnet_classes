﻿using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.UI;
using ToDoApp.Models;
using ToDoApp.BusinessLogic.Controllers;

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
            ShowToDoLists();
        }
        private void ShowListItems(int selectedListId)
        {
            var itemsList = ToDoListController.GetListItems(selectedListId);
            var userAnswer = ConsoleMenu.PrintToDoItemsMenu(itemsList);

            if (userAnswer == "1")
                AddNewItemToDoList(selectedListId);

            if (userAnswer == "2")
                ShowToDoLists();

            if (userAnswer == "3")
                return;
        }
        private void AddNewItemToDoList(int selectedListId)
        {
            Console.WriteLine("Provide the name of the item: ");

            var userAnswer = Console.ReadLine();

            ToDoListController.AddNewItemToList(selectedListId, userAnswer);
            ShowListItems(selectedListId);
            
        }
    }
}
