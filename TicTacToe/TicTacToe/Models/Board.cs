using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Board
    {
        public List<string[]> BoardRows { get; set; }

        public Board()
        {
            GenerateBoardNodes();
        }

        private void GenerateBoardNodes()
        {
            for(int x = 0; x < 3; x++)
            {
                var boardRow = new [] {"*", "*", "*"};
                BoardRows.Add(boardRow);
            }
        }
    }
}
