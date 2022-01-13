using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.BusinessLogic.Controllers
{
    internal class ToDoListController
    {
        private int CurrentListId { get; set; }
        public List<ToDoList> ToDoLists { get; set; }
        public ToDoList ToDoList { get; set; }
        private ToDoItemController ToDoItemController { get; set; }

        public ToDoListController()
        {
            CurrentListId = 1;
            ToDoLists = new List<ToDoList>();
            ToDoItemController = new ToDoItemController();
        }

        public ToDoList CreateNewToDoList(string listName)
        {
            var newToDoList = new ToDoList
            {
                Id = CurrentListId,
                Name = listName,
                ToDoItems = new List<ToDoItem>()

            };

            ToDoLists.Add(newToDoList);
            CurrentListId ++;
            return newToDoList;
        }
      
        public bool AddNewItemToList(int listId, string itemName)
        {

            foreach (var list in ToDoLists)
            {
                if (list.Id == listId)
                {
                    var newItem = ToDoItemController.CreateNewToDoItem(itemName);
                    list.ToDoItems.Add(newItem);
                    return true;
                }
                
            }
            return false;
        }

        public bool RemoveSelectedToDoItem(int selectedListId)
        {
            Console.WriteLine("Provide Item number to remove: ");

            foreach (var list in ToDoLists)
            {
                if (selectedListId == list.Id)
                    try
                    {
                        var selectedItemIndex = int.Parse(Console.ReadLine()) - 1;
                        var removeItem = ToDoList.ToDoItems[selectedItemIndex];
                        ToDoList.ToDoItems.Remove(removeItem);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Zły indeks " + ex.Message);
                    }
                Console.ReadKey();
                return true;
            }
            return false;
        }

        public List<ToDoItem> GetListItems(int listId)
        {
            foreach (var list in ToDoLists)
            {
                if (list.Id == listId)
                {
                    return list.ToDoItems;              
                }
            }
            var newList = new List<ToDoItem>();

            return newList;
        }
    }
}
