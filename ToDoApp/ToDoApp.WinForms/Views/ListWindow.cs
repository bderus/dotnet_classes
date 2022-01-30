using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.BusinessLogic.Controllers;
using ToDoApp.Models;

namespace ToDoApp.WinForms.Views
{
    public partial class ListWindow : Form
    {
        private ToDoListController _listController { get; set; }
        private ToDoList _currentList { get; set; }

        public ListWindow(ToDoList currentList, ToDoListController currentController)
        {
            InitializeComponent();
            _listController = currentController;
            _currentList = currentList;
            
            RefreshItemsList();
        }

        private void RefreshItemsList()
        {
            itemContainer.DataSource = null;
            itemContainer.DataSource = _currentList.ToDoItems;
            itemContainer.DisplayMember = "Name";
            itemContainer.ValueMember = "Id";

        }

        private void newItem_Click(object sender, EventArgs e)
        {
            var itemName = textBox1.Text;
            _listController.AddNewItemToList(_currentList.Id, itemName);
            textBox1.Clear();
            RefreshItemsList();
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            itemContainer.DataSource = null;
            var itemIndex = itemContainer.SelectedIndex;
            itemContainer.Items.RemoveAt(itemIndex);
            RefreshItemsList();

        }
    }
}
