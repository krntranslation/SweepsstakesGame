using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;

        public string newSweepstakes;
        public string contestant1;

        public void GetManager()
        {

            manager = UserInterface.GetManager();

        }
        public void CreateSweepstakes()
        {
            Console.WriteLine("Please add a sweepstakes");
            newSweepstakes = Console.ReadLine();
            Sweepstakes newSweep = new Sweepstakes(newSweepstakes);

            contestant1 =(UserInterface.GetUserInfo());   //trying to return the new contestant to registercontestant

            newSweep.RegisterContestant(contestant1);       // stuck on how to register contestant, tried converting to string

        }
    }
 
}

