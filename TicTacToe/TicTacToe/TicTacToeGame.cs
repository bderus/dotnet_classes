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

        private string CurrentPlayer { get; set; }

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
                    PrintBoard();
                    Console.WriteLine("KONIEC GRY");
                    return;
                }

                SwitchCurrentPlayer();
                Console.Clear();
            }
        }

        private void SwitchCurrentPlayer()
        {
            //TODO - Implement method which switches current player (from "X" to "O" and vice versa)
            if (CurrentPlayer == "X")
                CurrentPlayer = "0";
            else if (CurrentPlayer == "0")
                CurrentPlayer = "X";
            
 
        }

        private bool CheckEndgameConditions()
        {
                //TODO - Implement method which checks endgame conditions - draw and win
                if (_board[0][0] == _board[0][1] && _board[0][1] == _board[0][2] && _board[0][2] == CurrentPlayer)
                    return true;               

                if (_board[1][0] == _board[1][1] && _board[1][1] == _board[1][2] && _board[1][2] == CurrentPlayer)             
                    return true;
                

                if (_board[2][0] == _board[2][1] && _board[2][1] == _board[2][2] && _board[2][1] == CurrentPlayer)               
                    return true;
                
                if (_board[0][0] == _board[1][0] && _board[1][0] == _board[2][0] && _board[2][0] == CurrentPlayer)
                    return true;
 
                if (_board[0][1] == _board[1][1] && _board[1][1] == _board[2][1] && _board[2][1] == CurrentPlayer)
                    return true;

                if (_board[0][2] == _board[1][2] && _board[1][2] == _board[2][2] && _board[2][2] == CurrentPlayer)
                    return true;

                if (_board[0][0] == _board[1][1] && _board[1][1] == _board[2][2] && _board[2][2] == CurrentPlayer)
                    return true;

                if (_board[2][0] == _board[1][1] && _board[1][1] == _board[0][2] && _board[0][2] == CurrentPlayer)
                    return true;
                

                foreach (var item in _board)
                    foreach (var item2 in item)
                        if (item2 == "*")
                            return false;
                //TODO - This method returns bool <- it is used in the Play() method to check if the game should be ended
                return true;

                
        }

        private void PlayerChoice()
        { 
            Console.WriteLine("Wybierz Pole: ");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                _board[0][0] = CurrentPlayer;
                
            }
            if (userInput == "2")
            {
                _board[0][1] = CurrentPlayer;

            }
            if (userInput == "3")
            {
                _board[0][2] = CurrentPlayer;

            }
            if (userInput == "4")
            {
                _board[1][0] = CurrentPlayer;

            }
            if (userInput == "5")
            {
                _board[1][1] = CurrentPlayer;

            }
            if (userInput == "6")
            {
                _board[1][2] = CurrentPlayer;

            }
            if (userInput == "7")
            {
                _board[2][0] = CurrentPlayer;

            }
            if (userInput == "8")
            {
                _board[2][1] = CurrentPlayer;

            }
            if (userInput == "9")
            {
                _board[2][2] = CurrentPlayer;

            }
                //TODO - Implement missing player selections; *Extra - Implement user input validation
            
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
