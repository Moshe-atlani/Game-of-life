using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL2._0
{
    class ConsoleGridShower: interface_IGridShower
    {
        public void show(Board board)
        {
            var grid = board.getGrid();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j].GetState());
                }

                Console.WriteLine();
            }
        }
    }
}
