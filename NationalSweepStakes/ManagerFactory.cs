using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class ManagerFactory
    {
        public void PickStackOrQuene(string value)
        {
            Console.WriteLine("How do you want to access the list? stack or quene");
            Console.ReadLine();
            switch (value.ToLower())
            {
                case "stack":
                    SweepstakesStackManager();
                    break;
                case "quene":
                    SweepstakesQueueManager();
                    break;
                default:
                    break;


            }
        }
    }


}
