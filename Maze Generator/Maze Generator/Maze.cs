using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Generator
{
    public class Maze
    {
        public int SizeX { get; }
        public int SizeY { get; }
        Cell[,] cells;

        public Maze(int y, int x)
        {
            cells = new Cell[y, x];
            for(int i = 0; i < y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
            SizeX = x;
            SizeY = y;
        }

        public Cell this[int i, int j]
        {
            get => cells[i, j];
            set => cells[i, j] = value;
        }
    }
}
