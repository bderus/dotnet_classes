using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Tictactoe
    {
        private List<List<string>> Board = new List<List<string>>
        {
            new List<string>
            {
                "*","*","*"
            },
            new List<string>
            {
                "*","*","*"
            },
            new List<string>
            {
                "*","*","*"
            },

        };

        private string CurrentPlayer { get; set; }

        public Tictactoe(string currentPlayer)
        {
            CurrentPlayer = currentPlayer;
        }

        public void StartGame()
        {
            PrintBoard();
            PlayerChoice();
        }

        private void PlayerChoice()
        { 
            Console.WriteLine("Wybierz Pole: ");
            var userinput= Console.ReadLine();
            if (userinput== "1")
            {
                Board[0][0] = CurrentPlayer;
                
            }
            if (userinput == "2")
            {
                Board[0][1] = CurrentPlayer;

            }
            PrintBoard();
        }
        

        private void PrintBoard()
        {
            var i = 0;
            foreach (List<string> element in Board)
            {
                Console.WriteLine(String.Join('|', element));


                if (i < 2)
                {
                    Console.WriteLine("_____");
                    i++;
                }
            }
        }
    }
}
