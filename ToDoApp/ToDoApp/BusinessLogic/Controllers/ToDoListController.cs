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
        private int CurrentId { get; set; }
        public List<ToDoList> ToDoLists { get; set; }
        private ToDoItemController ItemController { get; set; }

        public ToDoListController()
        {
            ToDoLists = new List<ToDoList>();
            CurrentId = 0;
            ItemController = new ToDoItemController();
        }

        public ToDoList AddNewList(string listName)
        {
            var newList = new ToDoList
            {
                Id = CurrentId,
                Name = listName,
                ToDoItems = new List<ToDoItem>()
            };

            ToDoLists.Add(newList);

            CurrentId++;

            return newList;
        }

        public bool AddItemToList(int listId, string itemName)
        {
            var selectedList = ToDoLists.FirstOrDefault(l => l.Id == listId);

            if (selectedList == null)
                return false;

            var itemToAdd = ItemController.CreateNewItem(itemName);
            selectedList.ToDoItems.Add(itemToAdd);

            return true;
        }

        public List<ToDoItem> GetListItems(int listId)
        {
            var listItems = ToDoLists.FirstOrDefault(l => l.Id == listId)?.ToDoItems;

            return listItems;
        }
    }
}
