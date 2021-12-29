using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.BusinessLogic.Controllers
{
    internal class ToDoItemController
    {
        private int CurrentItemId { get; set; }

        public ToDoItemController()
        { 
            CurrentItemId = 1;
        }

        public ToDoItem CreateNewToDoItem(string itemName)
        {
            var toDoItem = new ToDoItem
            {
                Id = CurrentItemId,
                Name = itemName,
                IsDone = false
            };

            CurrentItemId++;

            return toDoItem;
           
        }
            
    }
}
