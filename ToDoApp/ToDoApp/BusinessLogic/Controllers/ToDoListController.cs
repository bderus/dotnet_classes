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
        private List<ToDoList> ToDoLists { get; set; }
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
        public bool AddNewItemToList(int ListId, string itemName)
        {
            foreach (var list in ToDoLists)
            {
                if (list.Id == ListId)
                {
                    ToDoItemController.CreateNewToDoItem(itemName);
                    list.ToDoItems.Add();
                }
                
            }
            return true;
        }



    }
}
