using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Program
    {
        static void Main(string[] args)
        { 

            Board board = new Board();
            Rules rules = new Rules();

            board.ShowTheGrid();
            rules.NewStepRulse();//cencer changer le  coeur du grid(dans le Board)--->donc changer le print de ShowTheGrid


        }
    }
}
