using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            ConsoleGridShower shower = new ConsoleGridShower();

            shower.show(board);
            board.update();//je pense que dans cette peoula il faut touche le coeur de chaque cell
            //shower.show(board);
        }
    }
}
