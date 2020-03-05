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
            Board board = new Board();
            ConsoleGridShower shower = new ConsoleGridShower();

            //TimeSpan ts = new TimeSpan(0, 0, 1);
            for (int i = 0; i < 300; i++)
            {
                shower.Show(board);
                board.update();//je pense que dans cette peoula il faut touche le coeur de chaque cell
                               //shower.show(board);
                Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}
