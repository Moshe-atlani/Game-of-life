using System;
using System.Collections.Generic;
using System.IO;
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
        private int lenght;
        private int width_b;
        private string v;

        public Board(int lenght = 10, int width_b = 10)
        {
            this.lenght = lenght;
            this.width_b = width_b;

            grid = new Cell[lenght, width_b];
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

        public Board(string boardFilepath)//sa me parai pas mal/ faire un CR
        {
            string content = File.ReadAllText(boardFilepath);

            int countRN = 0;
            int col = 0;
            int row = 0;
            
            while (content != null)//verifi combien y a til de col et row pour pouvoir fair le new cell
            {
                if (content.Last() == ' ' || content.Last() == '*')
                    col++;
                else if (countRN == 4)
                {
                    row++;
                    countRN = 0;
                }
                else
                    countRN++;

                content.Remove(content.Length - 1);//remove the last char
            }
            grid = new Cell[row, col];
            //row = 0;
            //col = 0;
            //content = File.ReadAllText(boardFilepath);//if content are empty
            int x = 0, y = 0;
            while (content != null)//fulfilled the grid 
            {
                if (content.Last() == ' ' || content.Last() == '*')
                {
                    grid[x, y].SetNewState(content.First());
                    x++;
                }
                else if (countRN == 4)
                {
                    y++;
                    countRN = 0;
                }
                else
                    countRN++;

                content.Remove(0, 1);//remove the first char
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
            if (row < width_b || col < lenght || row >= width_b || col >= lenght)//j ai rajouter 
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
                    //else if (nr == 0) { grid[h, w].SetNewState('*'); }//c moi qui a rajouter
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
