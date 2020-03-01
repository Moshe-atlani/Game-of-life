using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL2._0
{
    public class Board
    {
        private Cell[,] grid;
        //pas tros compri
        private int height = 3; //bottom right pos: grid[height-1][width-1]
        private int width = 3;
        //pas trop compri

        public Board()
        {
            grid = new Cell[10, 10];
            Random rnd = new Random();
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    grid[row, col] = new Cell();
                    if (rnd.Next() % 2 == 0)
                    {
                        grid[row, col].SetNewState('*');
                        grid[row, col].updateState();
                    }
                  //  Console.Write(grid[row, col].GetState() );
                }
               // Console.WriteLine();
            }
        }

        public Cell[,] getGrid()
        {
            return grid;
        }

        public int neighboursCountAt(int row, int col)
        {
            int sum = 0;
            // Positions numbered as phone dial
            if (row != 0 && col != 0)
            {    //1
                if (isAlive(row - 1, col - 1))
                {
                    sum++;
                }
            }

            if (row != 0)
            {
                if (isAlive(row - 1, col))
                { //2
                    sum++;
                }
            }

            if (row != 0 && col != width - 1)
            {//3
                if (isAlive(row - 1, col + 1))
                {
                    sum++;
                }
            }
            if (col != 0)
            {
                if (isAlive(row, col - 1))
                { //4
                    sum++;
                }
            }
            //self
            if (col != width - 1)
            {
                if (isAlive(row, col + 1))//ici
                { //6
                    sum++;
                }
            }

            if (row != height - 1 && col != 0)
            {
                if (isAlive(row + 1, col - 1))
                { //7
                    sum++;
                }
            }

            if (row != height - 1)
            {
                if (isAlive(row + 1, col))
                { //8
                    sum++;
                }
            }

            if (row != height - 1 && col != width - 1)
            {
                if (isAlive(row + 1, col + 1))
                { //9
                    sum++;
                }
            }

            return sum;
        }

        public bool isAlive(int row, int col)//ici
        {
            if (row < 0 || col < 0 || row >= 10 || col >=10)//j ai rajouter 
                return false;
            return grid[row, col].GetState() == '*';
        }

        private void prepare()
        {
            for (int h = 0; h < grid.GetLength(1); h++)
            {
                for (int w = 0; w < grid.GetLength(0); w++)
                {
                    int nr = neighboursCountAt(h, w);//ici
                    if (nr < 2) { grid[h, w].SetNewState(' '); }  //underpop
                    else if (nr > 3) { grid[h, w].SetNewState(' '); } //overcrowd
                    else if (nr == 3) { grid[h, w].SetNewState('*'); } //born
                    else if (nr == 2) { grid[h, w].SetNewState(grid[h, w].GetState()); } // stay same
                }
            }
        }

        private void commit()
        {
            for (int h = 0; h < grid.GetLength(0); h++)
            {
                for (int w = 0; w < grid.GetLength(1); w++)
                {
                    grid[h, w].updateState();
                }
            }
        }

        public void update()
        {
            prepare();//ici
            commit();
        }
    }

}
