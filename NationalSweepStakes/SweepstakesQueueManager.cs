using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class SweepstakesQueueManager : SweepstakesManager
    {
       public void EnqueneOnQuene()
        {
            Queue<int> quene = new Queue<int>();

            quene.Enqueue(999);
            quene.Enqueue(998);
            quene.Enqueue(997);

        }

    }
}
