using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<string> stack = new Stack<string>();
        
        public SweepstakesStackManager()
        {

        }
        public Sweepstakes GetSweepstakes()
        {
            
            // write method to get the sweepstakes the user wants
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
           //need to put in the sweepstakes into a stack 
        }

       
        
        //public void PushToStack()
        //{
        //    Stack<string> stack = new Stack<string>();
        //    stack.Push("");

        //}
    }
}
