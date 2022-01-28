using System;
using System.Windows.Forms;
using ToDoApp.BusinessLogic.Controllers;
using ToDoApp.Models;

namespace ToDoApp.WinForms.Views
{
    public partial class MainWindow : Form
    {
        public ToDoListController _listController { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _listController = new ToDoListController();
        }


        private void newList_Click(object sender, EventArgs e)
        {
            var listName = textBox1.Text;
            if (listName.Length >= 3)
            {
                var newList = _listController.CreateNewToDoList(listName);
                listContainer.Items.Add(newList);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Nazwa listy jest za krótka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        void listContainer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = listContainer.IndexFromPoint(e.Location);
            
            if (index == ListBox.NoMatches) 
                return;

            var selectedList = listContainer.Items[index] as ToDoList;
            ListWindow listWindow = new ListWindow(selectedList, _listController);

            if (selectedList == null)
                return;

            listWindow.ShowDialog();
        }
        
        private void RemoveList_Click(object sender, EventArgs e)
        {
            // Znalezc podswietlony Item
            var selectedList = listContainer.SelectedIndex;
            listContainer.Items.RemoveAt(selectedList);

        }
    }
}
