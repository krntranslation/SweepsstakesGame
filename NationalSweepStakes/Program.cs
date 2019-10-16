using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            
            UserInterface.GetUserInfo("", "", "");
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.RegisterContestant();

            


        }
    }
}
