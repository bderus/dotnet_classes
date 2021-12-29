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
        private int CurrentId { get; set; }

        public ToDoItemController()
        { 
            CurrentId = 1;
        }

        public ToDoItem CreateNewToDoItem(string itemName)
        {
            var toDoItem = new ToDoItem
            {
                Id = CurrentId,
                Name = itemName,
                IsDone = false
            };

            CurrentId++;

            return toDoItem;
           
        }
            
    }
}
