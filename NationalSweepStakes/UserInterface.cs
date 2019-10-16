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

        public static Contestant GetUserInfo(string firstName, string lastName, string emailAddress)
        {
       
            Console.WriteLine("Welcome to the sweepstakes! Please enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Please type in your email address");
            emailAddress = Console.ReadLine();
            Console.WriteLine("Generating your registration number");
    
            Contestant contestant = new Contestant(firstName, lastName, emailAddress);

            return contestant;
       
        
        }
       
    }
}
