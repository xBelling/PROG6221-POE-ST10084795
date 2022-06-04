using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApp
{
    internal class Expenditure
    {
        public static double totalExpenses { get; set; } //Get and Set

        //Method to get and store the user's expenses
        public static void MonthlyExpenses()
        {
            TotalExpense te = new TotalExpense();
            Console.WriteLine("Enter the monthly expenditure in the following categories :");

            //List to store the name of the various expenses
            List<string> expenses = new List<string>();
            expenses.Add("Groceries");
            expenses.Add("Water and Lights");
            expenses.Add("Travel Costs (Including Petrol)");
            expenses.Add("Cellphone and Telephone Bill");

            //Reads the list of expenses and prompts the user for a value for each
            double expVal = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.Write(expenses[i] + " : R");
                expVal = Convert.ToDouble(Console.ReadLine());
                TotalExpense.expnsVal.Add(expVal);
            }

            /*
             * Asks the user if there are any additional expenses,
             * and if so, prompts the user for the amount of additional expenses
             * will then prompt the user to enter the name of the expense, one by one
             * and will prompt for a value after each expense name input
             */
            Console.Write("\nDo you have any other monthly expenses?\n" +
                "Enter 1 for YES or enter any other key for NO : --> ");
            string answer = Console.ReadLine();
            string otherExpns = "";
            if (answer.Equals("1"))
            {
                Console.WriteLine("\nEnter the name(s) of your other expense(s)," +
                    "\nEnter 1 when asked for the next expense to stop adding expenses\n");
                int count = 0;
                while (count > -1)
                {
                    Console.Write("Expense " + (count + 1) + ". --> ");
                    otherExpns = Console.ReadLine();
                    if (otherExpns.Equals("1"))
                    {
                        break; //If the user enters 1, the while loop ends
                    }
                    expenses.Add(otherExpns);
                    //Prints the entered expense and prompts for its value
                    Console.Write("Monthly expenditure on " + expenses[count + 4] + " : R");
                    expVal = Convert.ToDouble(Console.ReadLine());
                    //The value of the named expense is added to the expensesValue list
                    TotalExpense.expnsVal.Add(expVal);
                    count++;
                }
            }
            //Sums up all the values in the list that stores the values of the user's expenses
            Expenditure.totalExpenses = TotalExpense.expnsVal.Sum(x => Convert.ToDouble(x));
        }

    }
}
