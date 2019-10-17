using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();


        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("sweepstake removed");
            return stack.Pop();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        { 
           stack.Push(sweepstakes);
        }

     
    }
}
