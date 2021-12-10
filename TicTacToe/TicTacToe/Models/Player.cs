using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Player
    {
        public string PlayerSymbol { get; set; }

        public Player(string playerSymbol)
        {
            PlayerSymbol = playerSymbol;
        }
    }
}
