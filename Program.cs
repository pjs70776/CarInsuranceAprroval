using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceAprroval
{
    class Program
    {
        static void Main(string[] args)
        {

            //Introduction to program
            Console.WriteLine("Car Insurance Approval Application");
            Console.ReadLine();

            //Input from applicant
            Console.WriteLine("What is your age?");
            int applicantAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Enter true or false");
            bool applicantDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speedinng tickets have you had?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            //Qualifications for insurance
            Console.WriteLine(applicantAge > 15 && speedingTickets <= 3 && !applicantDUI);

            //Closing statement
            Console.WriteLine("Look at the above statement to see if you are qualified!");
            Console.ReadLine();
            

        }
    }
}
