using System;

namespace TicTacToe
{
    class Program
    {

        public static void Main(string[] args)
        {
            //TODO - Add possibility to select starting player symbol and pass it to constructor as variable
            Console.WriteLine("Choose X or O: ");
            var selectedPlayer = Console.ReadLine();
            TicTacToeGame ticTacToeGame = new TicTacToeGame(selectedPlayer);

           ticTacToeGame.Play();
        }
    }
}
