using System;

namespace TicTacToe
{
    class Program
    {

        public static void Main(string[] args)
        {
            //TODO - Add possibility to select starting player symbol and pass it to constructor as variable
           TicTacToeGame ticTacToeGame = new TicTacToeGame("X");

           ticTacToeGame.Play();
        }
    }
}
