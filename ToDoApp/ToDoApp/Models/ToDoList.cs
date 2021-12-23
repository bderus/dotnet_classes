using System.Collections.Generic;

namespace ToDoApp.Models
{
    internal class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
