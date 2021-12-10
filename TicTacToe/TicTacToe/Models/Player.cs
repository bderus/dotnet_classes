using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Player
    {
        public string PlayerType { get; set; }

        public Player(string playerType)
        {
            PlayerType = playerType;
        }
    }
}
