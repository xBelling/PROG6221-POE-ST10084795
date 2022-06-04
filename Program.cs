using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlannerApp
{
    internal class Program
    {
        public delegate void initialisingDelegate(int timeDel); //Delegate for the threading method
        public static string answer; //String to hold the answer to whether the user is buying or renting a property
        public static string question; //String to hold the answer to whether the user is buying a vehicle or not
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Initialising"); //Splash screen
            initialisingDelegate id = timeDel => //Lambda Delegate that houses a threading method
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(" . ");
                    Thread.Sleep(timeDel);
                }
            };
            id.Invoke(1000); //Invokes the threading method

            Console.WriteLine("\n===========================================================\n" +
                "\t--- Welcome to the Budget Planner App ---\n" +
                "===========================================================");//Splash screen

            Console.WriteLine("Monthly Income\n" +
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
                "\nEnter 1 for RENTING or enter any other key for BUYING : --> ");
            answer = Console.ReadLine();
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
                "Monthly Vehicle Expenditure\n" +
                "-----------------------------------------------------------");
            Console.Write("Are you going to buy a vehicle?" +
                "\nEnter 1 for YES or enter any other key for NO : --> ");
            question = Console.ReadLine();
            if (question.Equals("1")) //If "1" is entered the MonthlyAmount method from the Vehicle class is invoked
            {
                Vehicle v = new Vehicle();
                v.MonthlyAmount(); //Invokes the MonthlyAmount method from the Vehicle class
            }

            Console.WriteLine("\n-----------------------------------------------------------\n" +
                "Total Monthly Expenses\n" +
                "-----------------------------------------------------------");
            TotalExpense.ExpensesValue(); //Invokes the ExpensesValue method from the TotalExpenses class

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
