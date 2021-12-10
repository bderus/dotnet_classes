using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TicTacToe.Models;

namespace TicTacToe.BusinessLogic
{
    public class TicTacToeGame
    {
        private const string SymbolX = "X";
        private const string SymbolO = "O";
        private const string WrongInputError = "Wrong Input!";

        private readonly Player _playerX = new Player(SymbolX);
        private readonly Player _playerO = new Player(SymbolO);
        private readonly Dictionary<string, Point> _pointMappingDictionary = new Dictionary<string, Point>
        {
            {"1", new Point(0,0)},
            {"2", new Point(0,1)},
            {"3", new Point(0,2)},
            {"4", new Point(1,0)},
            {"5", new Point(1,1)},
            {"6", new Point(1,2)},
            {"7", new Point(2,0)},
            {"8", new Point(2,1)},
            {"9", new Point(2,2)},
        };

        private Board CurrentBoard { get; set; }
        private Player CurrentPlayer { get; set; }

        public void StartGame()
        {
            CurrentBoard = new Board();
            SelectPlayer();
            Play();
        }

        private void Play()
        {
            while (true)
            {
                Console.WriteLine($"It's {CurrentPlayer.PlayerSymbol} time to play!");

                PrintCurrentBoard();
                MakeMove();

                if (CheckEndgameConditions(out var gameResult))
                {
                    Console.WriteLine($"Game has ended with result: {gameResult}");
                    return;
                }

                SwitchPlayers();
                Console.Clear();
            }
        }

        private void PrintCurrentBoard()
        {
            foreach (var row in CurrentBoard.BoardRows)
            {
                Console.WriteLine(string.Join('|', row));
            }
        }

        private void SwitchPlayers()
        {
            CurrentPlayer = CurrentPlayer == _playerX ? _playerO : _playerX;
        }

        private bool CheckEndgameConditions(out string gameResult)
        {
            gameResult = "Playing";

            foreach (var row in CurrentBoard.BoardRows)
            {
                if (row.Contains("*")) 
                    return false;
                
                gameResult = "Draw";
                return true;
            }

            return false;
        }

        private void MakeMove()
        {
            while (true)
            {
                Console.WriteLine("Please select your next move (1-9): ");
                var userInput = Console.ReadLine() ?? WrongInputError;

                if (userInput == WrongInputError || !_pointMappingDictionary.Keys.Contains(userInput))
                {
                    Console.WriteLine($"{WrongInputError} Please try again!");
                    continue;
                }

                var selectedPoint = _pointMappingDictionary[userInput];
                if (CurrentBoard.BoardRows[selectedPoint.X][selectedPoint.Y] == "*")
                {
                    CurrentBoard.BoardRows[selectedPoint.X][selectedPoint.Y] = CurrentPlayer.PlayerSymbol;
                }
                else
                {
                    Console.WriteLine($"{WrongInputError} Selected spot is already taken! Please try again!");
                    continue;
                }

                break;
            }
        }

        private void SelectPlayer()
        {
            while (true)
            {
                Console.WriteLine("Please select your player symbol (X,O): ");
                var userInput = Console.ReadLine();

                if (userInput == SymbolX)
                {
                    CurrentPlayer = _playerX;
                }
                else if (userInput == SymbolO)
                {
                    CurrentPlayer = _playerO;
                }
                else
                {
                    Console.WriteLine($"I don't understand this symbol - {userInput}");
                    continue;
                }

                break;
            }
        }
    }
}
