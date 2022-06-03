using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApp
{
    internal class TotalExpense
    {
        //List to store the values of the user's expenses
        public static List<double> expnsVal = new List<double>();
        //Delegate to notify the user that their total expenses exceed 75% of their net income
        public delegate void WarningDelegate();
        
        public static void ExpensesValue()
        {
            //Adding the expenses from other classes to the list
            if (Program.answer.Equals("1"))
            {
                //If the user chose to rent accommodation, the rent payment is added to the list
                expnsVal.Add(Rental.rentalPayment);
            }
            else
            {
                //If the user chose to buy a house, the home loan payment is added to the list
                expnsVal.Add(HomeLoan.homeLoanRepayment);
            }

            if (Program.question.Equals("1"))
            {
                //If the user chose to buy a vehicle, the vehicle payment is added to the list
                expnsVal.Add(Vehicle.vehicleRepay);
            }

            //Invoking the delegate
            WarningDelegate wd = new WarningDelegate(Warning);
            wd();

            //Sorting the list into descending order
            expnsVal.Sort();
            expnsVal.Reverse();

            Console.WriteLine("Income Tax Deduction --> R" + Income.incomeTaxDed);
            //Printing the sorted values
            Console.WriteLine("\nThe values of your expenses in descending order:\n");
            for (int i = 0; i < expnsVal.Count; i++)
            {
                Console.WriteLine("Expense " + (i + 1) + ". --> R" + expnsVal[i]);
            }
        }

        //Method used to determine if the user's expenses exceed 75% of their net income 
        public static void Warning()
        {
            double expnsTot = expnsVal.Sum(x => Convert.ToDouble(x));
            expnsTot = Math.Round(expnsTot, 2);

            //Warning notification
            if (expnsTot > ((Income.grossIncome - Income.incomeTaxDed) * 0.75))
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\t--- WARNING ---\t\t\t   \n" +
                    "Your monthly expenses exceed 75% of your net income\n");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
