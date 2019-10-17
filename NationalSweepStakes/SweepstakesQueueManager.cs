using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager 
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Remove sweepstakes");
            return queue.Dequeue();
        }

       

    }
}        
