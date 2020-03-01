using GOL.GridShowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Board
    {
        private char[,] grid;//'1' = live---'_' = death
        private IGridShower GridShower; 


        public Board()
        {
            GridShower = new ConsoleGridShower();
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
            GridShower.show(this);
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
