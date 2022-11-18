using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.UI;
using System.Threading;

namespace ToDoApp.BusinessLogic
{
    internal class App
    {
        public void StartApp()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            while (true)
            {
                var username = ConsoleMenu.PrintMainMenu();

                if (username == "1")
                    return;

                if (username == "2")
                    return;         
            }
        }
    }
}
