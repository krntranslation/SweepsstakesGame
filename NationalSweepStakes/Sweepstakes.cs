using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class Sweepstakes 
    {
        Dictionary<double, Contestant> contestantList = new Dictionary<double, Contestant>();

        public Sweepstakes boatPrize;
        public Sweepstakes carPrize;
        public Sweepstakes airplanePrize;

        //private int winningNumbers;

        public Sweepstakes(string name)
        {
            boatPrize = null;
            carPrize = null;
            airplanePrize = null;

        }
        public void RegisterContestant(Contestant contestant)
        {
            double registrationNumber = contestantList.Count + 1;
            contestant.registrationNumber = registrationNumber;
            contestantList.Add(registrationNumber, contestant); 

        }
        public void PickWinner()
        {
            Random random = new Random();
            double winningNumbers = random.Next(1, contestantList.Count);
            PrintContestantInfo(winningNumbers);
        }
        public void PrintContestantInfo(double winningNumbers)
        {

            winningNumbers = int.Parse(Console.ReadLine());
            string info;
            if (contestantList.ContainsKey(winningNumbers))
            {
                info = contestantList[winningNumbers].ToString();
                    
                Console.WriteLine(info + " Has won the sweepstakes");
            }
            else
            {
                Console.WriteLine("No contestant present");
                return;
            }
            

        }
    }


}
