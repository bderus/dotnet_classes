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

namespace ToDoApp.WinForms.Views
{
    public partial class ListWindow : Form
    {
        private ToDoItemController _itemController { get; set; }
        public ListWindow()
        {
            InitializeComponent();
            _itemController = new ToDoItemController();
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            var itemName = textBox1.Text;
            var newItem = _itemController.CreateNewToDoItem(itemName);
            itemContainer.Items.Add(newItem.Name);
        }
    }
}
