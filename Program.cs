using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlannerApplication
{
    internal class Program
    {
        public delegate void initialisingDelegate(int timeDel);
        static void Main(string[] args)
        {
            Console.Write("Initialising"); //Splash screen
            initialisingDelegate id = timeDel => //Lambda Delegate that houses a threading method
            {
                for (int i = 3; i > 0; i--)
                {
                    timeDel = 1000;
                    Console.Write(" . ");
                    Thread.Sleep(timeDel);
                }
            };
            id.Invoke(1000); //Invokes the threading method

            Console.WriteLine("\n-----------------------------------------------------------\n" +
                "\t--- Welcome to the Budget Planner App ---\n" +
                "-----------------------------------------------------------\n");//Splash screen

            Console.WriteLine("\nMonthly Income\n" +
                "-----------------------------------------------------------");
            Income inc = new Income();
            inc.MonthlyAmount(); //Invokes the MonthlyAmount method from the Income class

            Console.WriteLine("\n-----------------------------------------------------------\n" +
                "Monthly Expenses\n" +
                "-----------------------------------------------------------");
            Expenditure.MonthlyExpenses(); //Invokes the MonthlyExpenses method from the Expenditure class

            Console.WriteLine("\n-----------------------------------------------------------\n" +
                "Monthly Accommodation Expenditure\n" +
                "-----------------------------------------------------------");
            //Prompts the user for whether they are renting or buying a property
            Console.Write("Are you renting accommodaton or buying a property?" +
                "\nEnter 1 for renting or enter any other key for buying : --> ");
            string answer = Console.ReadLine();
            if (answer.Equals("1")) //If "1" is entered the MonthlyAmount method from the Rental class is invoked
            {
                Rental r = new Rental();
                r.MonthlyAmount();
            }
            else //If any other key besides "1" is entered the MonthlyAmount method from the HomeLoan class is invoked
            {
                HomeLoan hl = new HomeLoan();
                hl.MonthlyAmount();
            }

            Console.WriteLine("\n-----------------------------------------------------------\n" +
                "Monthly Net Income\n" +
                "-----------------------------------------------------------");
            AvailableMoney am = new AvailableMoney();
            am.MonthlyAmount(); //Invokes the MonthlyAmount method from the AvailableMoney class
            Console.WriteLine("-----------------------------------------------------------");

            //Keeps the console open
            Console.ReadLine();
        }
    }
}
