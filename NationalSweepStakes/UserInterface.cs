using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes
{
    public class UserInterface
    {
        public static void GetInfo(string contestantFirstName, string contestantLastName, string emailAddress, double registrationNumber)
        {
            Console.WriteLine("Write amount of contestants");
            double totalContestants = Convert.ToInt32(Console.ReadLine());
            List<Contestant> contestant = new List<Contestant>();
            for(int i = 0; i < totalContestants; i++)
            

            Console.WriteLine("Welcome to the sweepstakes! Please enter your first name");
            contestantFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            contestantLastName = Console.ReadLine();
            Console.WriteLine("Please type in your email address");
            emailAddress = Console.ReadLine();
            Console.WriteLine("Please enter in your registration number");
            registrationNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Thanks " + contestantFirstName + ", please make sure your information is correct\nemail adderess : " + emailAddress + " \nregistration number : " + registrationNumber);
            Console.ReadLine();
            //contestant.Add(new Contestant({ 0}, { 1}, { 2}, { 3}));

        }

    }
}