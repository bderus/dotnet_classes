using System;

namespace TicTacToe
{
    class Program
    {

        public static void Main(string[] args)
        {
           Tictactoe gameTictactoe = new Tictactoe("X");
           gameTictactoe.StartGame();
        }
    }
}
