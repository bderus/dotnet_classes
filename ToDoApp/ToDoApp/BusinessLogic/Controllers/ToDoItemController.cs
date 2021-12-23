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
            CurrentId = 0;
        }

        public ToDoItem CreateNewItem(string itemName)
        {
            var newItem = new ToDoItem
            {
                Id = CurrentId,
                IsDone = false,
                Name = itemName
            };

            CurrentId++;

            return newItem;
        }

        public void ToggleIsDone(ToDoItem item)
        {
            item.IsDone = !item.IsDone;
        }
    }
}
