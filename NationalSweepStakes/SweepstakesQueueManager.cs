using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {

        Queue<string> queue = new Queue<string>();
        
        public SweepstakesQueueManager()
        {
            
        }
        public Sweepstakes GetSweepstakes()
        {
            //get the sweepstakes im looking for
       
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //insert the sweepstakes into Quene
        
        }
       

    }
}        
//public void EnqueneOnQuene()
        //{
        //    Queue<string> queue = new Queue<string>();

        //    queue.Enqueue("");

        //}
