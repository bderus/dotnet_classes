using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class BoardNode
    {
        public Point Coords { get; set; }
        public string Value { get; set; }

        public BoardNode(Point coords)
        {
            Coords = coords;
            Value = "*";
        }
    }
}
