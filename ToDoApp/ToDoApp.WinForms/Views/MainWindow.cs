using System;
using System.Windows.Forms;
using ToDoApp.BusinessLogic.Controllers;

namespace ToDoApp.WinForms.Views
{
    public partial class MainWindow : Form
    {
        private ToDoListController _listController { get; set; }

        private ToDoItemController _itemController { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _listController = new ToDoListController();
            _itemController = new ToDoItemController();
        }


        private void newList_Click(object sender, EventArgs e)
        {
            var listName = textBox1.Text;
            if (listName.Length >= 3)
            {
                var newList = _listController.CreateNewToDoList(listName);
                listContainer.Items.Add(newList.Name);
            }
            else
            {
                var userAnswer = MessageBox.Show("Nazwa listy jest za krótka", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (userAnswer == DialogResult.Yes)
                {
                    MessageBox.Show("Jesteś super");
                }
                else if (userAnswer == DialogResult.No)
                {
                    MessageBox.Show("O Ty chuju");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void newItem_Click(object sender, EventArgs e)
        {
            var newItem = _itemController.CreateNewToDoItem("itemName");
        }
    }
}
