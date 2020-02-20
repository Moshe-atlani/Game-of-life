using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Board
    {
        public char[,] grid;//'1' = live---'_' = death

        public Board()
        {
            grid = new char[,]
        {
        { '1', '_', '_', '_', '_', '_', '_', '_', '1', '1',},//1
        { '_', '_', '1', '_', '_', '1', '_', '_', '_', '_',},//2
        { '_', '1', '1', '_', '1', '1', '1', '_', '_', '_',},//3
        { '_', '1', '_', '_', '_', '1', '_', '_', '_', '_',},//4
        {'_', '_', '_', '_', '_', '_', '_','1', '_','1',},//5
        { '_', '_', '_', '_','1', '_', '_', '_', '1', '1',},//6
        {'_', '1', '_', '_', '1', '_', '_', '1','_', '_',},//7
        { '1','1','_', '_' ,'_', '_','_', '_', '_', '_',},//8
        { '1', '1', '_', '_', '1', '_', '_', '1', '_', '_',},//9
        { '1', '1', '_', '_', '_', '_', '_', '_', '_', '1',}//10
        };

        }

        public char[,] GetGrid()
        {
            return grid;
        }

        public void ShowTheGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i,j]);
                }
                Console.WriteLine("test ");
                Console.WriteLine("secou ets");

            }
        }

        public void ChangeTheCell(int i, int j, char dieOrLive)
        {
            grid[i, j] = dieOrLive;
        }

        public void ChangeTheGrid(char[,] new_grid)
        {
            grid = new_grid;
        }
    }
}
