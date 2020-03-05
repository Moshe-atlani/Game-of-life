using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL2._0
{
    public class Cell
    {
        private char state ;
        private char newState;

        public Cell()
        {
            state = ' ';
        }

        public Cell(char state)//rempli this.state
        {
            this.state = state;
        }

        public void SetState(char state)
        {
            this.state = state;
        }

        public void SetNewState(char state)//recois le prochain state et rempli avec ca le newState
        {
            newState = state;
        }

        public void updateState()//rempli state avec newState pour que ca se mais a jour dison 
        {
            state = newState;
        }

        public char GetState()
        {
            return state;
        }
    }

}
