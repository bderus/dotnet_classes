using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        private readonly List<List<string>> _board = new List<List<string>>
        {
            new List<string> {
                "*","*","*"
            },
            new List<string> {
                "*","*","*"
            },
            new List<string> {
                "*","*","*"
            }
        };

        private string CurrentPlayer { get; }

        public TicTacToeGame(string currentPlayer)
        {
            CurrentPlayer = currentPlayer;
        }

        public void Play()
        {
            while (true)
            {
                PrintBoard();
                PlayerChoice();

                if (CheckEndgameConditions())//if the method returns true -> do whatever is inside of the IF block
                {
                    //TODO - End the game here
                }

                SwitchCurrentPlayer();
            }
        }

        private void SwitchCurrentPlayer()
        {
            //TODO - Implement method which switches current player (from "X" to "O" and vice versa)

            throw new NotImplementedException();
        }

        private bool CheckEndgameConditions()
        {
            //TODO - Implement method which checks endgame conditions - draw and win
            //TODO - This method returns bool <- it is used in the Play() method to check if the game should be ended

            throw new NotImplementedException();
        }

        private void PlayerChoice()
        { 
            Console.WriteLine("Wybierz Pole: ");
            var userInput= Console.ReadLine();

            if (userInput== "1")
            {
                _board[0][0] = CurrentPlayer;
                
            }
            if (userInput == "2")
            {
                _board[0][1] = CurrentPlayer;

            }
            //TODO - Implement missing player selections; *Extra - Implement user input validation
            PrintBoard();
        }
        

        private void PrintBoard()
        {
            var i = 0;

            foreach (var element in _board)
            {
                Console.WriteLine(string.Join('|', element));

                if (i < 2)
                {
                    Console.WriteLine("_____");
                    i++;
                }
            }
        }
    }
}
