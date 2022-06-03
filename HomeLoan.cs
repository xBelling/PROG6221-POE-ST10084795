using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApplication
{
    //Inherits the monthlyAmount method from the Expense class
    class HomeLoan : Expense
    {
        private double purchasePrice;
        private double deposit;
        private double interest;
        private string repayMonths;
        public static double homeLoanRepayment { get; set; } //Get and Set

        //Method that calculates the monthly home loan repayment
        public override void MonthlyAmount()
        {
            double principal;
            double years;
            double total;

            //Prompts for property value and reads
            Console.Write("Enter the full purchase price of the property that you are buying : --> R");
            purchasePrice = Convert.ToDouble(Console.ReadLine());
            //Prompts for desposit amount and reads
            Console.Write("Enter the deposit amount : R");
            deposit = Convert.ToDouble(Console.ReadLine());
            //Prompts for interest rate, displays desired format, and reads
            Console.Write("Enter the interest rate as a percantage (Format : 7.5% --> 7,5) : --> ");
            interest = Convert.ToDouble(Console.ReadLine());
            //Prompts for length of home loan repayment period, provides two options, and reads
            Console.Write("Enter the length of the home loan, between either 240 or 360 months in length --> ");
            repayMonths = Console.ReadLine();
            //If either "240" or "360" are not entered, displays error message and prompts for a valid entry
            while (!repayMonths.Equals("240") && !repayMonths.Equals("360"))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter a valid length of time, either 240 or 360 months in length : --> ");
                Console.ResetColor();
                repayMonths = Console.ReadLine();
                Console.WriteLine(repayMonths);
            }
            //Calculation of the home loan repayment using formula --> A = P(1 + (i * n))
            principal = purchasePrice - deposit; //Calculates P - the amount due
            interest = interest / 100; //Calculates the correct format of the interest rate for the formula
            years = Convert.ToInt32(repayMonths) / 12; //Calculates the home loan repayment period in years

            total = principal * (1 + (interest * years)); //Calculation using the formula

            homeLoanRepayment = total / Convert.ToInt32(repayMonths); //Calculates the monthly repayment
            homeLoanRepayment = Math.Round(homeLoanRepayment, 2); //Rounds off to two decimal places

            Console.WriteLine("\nYour home loan payment will be : R" + homeLoanRepayment + " per month"); //Displays monthly repayment

            //Issues an error message if the user's home loan repayment is more than a third of their gross income 
            if (homeLoanRepayment > (Income.grossIncome / 3))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t--- HOME LOAN APPROVAL IS UNLIKELY ---\t\t\t\n" +
                    "Your monthly home loan payment would exceed a third of your gross income");
                Console.ResetColor();
            }
        }
    }
}
