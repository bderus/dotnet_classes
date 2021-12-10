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
        public List<BoardNode> BoardNodes { get; set; }

        public Board()
        {
            GenerateBoardNodes();
        }

        private void GenerateBoardNodes()
        {
            for(int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    var currentPoint = new Point(x, y);
                    var boardNode = new BoardNode(currentPoint);
                    BoardNodes.Add(boardNode);
                }
            }
        }
    }
}
