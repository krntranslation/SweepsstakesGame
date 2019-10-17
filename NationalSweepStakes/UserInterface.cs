using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalSweepStakes;

namespace NationalSweepStakes
{


    public static class UserInterface 
    {

        public static Contestant GetUserInfo()
        {
       
            Console.WriteLine("Welcome to the sweepstakes! Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please type in your email address");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Generating your registration number");
    
            Contestant contestant = new Contestant(firstName, lastName, emailAddress);

            return(contestant);
       
        
        }
        public static ISweepstakesManager GetManager()
        {
            Console.WriteLine("please choose a manage\nEnter in either stack or queue.");
            string pickStackOrPop = Console.ReadLine();
            switch (pickStackOrPop)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("That's not a choice"));
            }
        }
       
    }
}
