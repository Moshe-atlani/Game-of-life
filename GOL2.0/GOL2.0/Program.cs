using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GOL2._0
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Board b = new Board("board_example.txt");
            //Board board = new Board(4,4);
            ConsoleGridShower shower = new ConsoleGridShower();

            for (int i = 0; i < 300; i++)
            {
                shower.Show(b);
                b.update();//je pense que dans cette peoula il faut touche le coeur de chaque cell
                               //shower.show(board);
                Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}
