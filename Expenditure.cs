using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApplication
{
    internal class Expenditure
    {
        public static double totalExpenses { get; set; } //Get and Set

        //Method to get and store the user's expenses
        public static void MonthlyExpenses()
        {
            Console.WriteLine("Enter the monthly expenditure in the following categories :");

            //List to store the name of the various expenses
            List<string> expenses = new List<string>();
            expenses.Add("Groceries");
            expenses.Add("Water and Lights");
            expenses.Add("Travel Costs (Including Petrol)");
            expenses.Add("Cellphone and Telephone Bill");

            //List to store the value of the user's expenses
            List<double> expensesValue = new List<double>();

            //Reads the list of expenses and prompts the user for a value for each
            double expVal = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.Write(expenses[i] + " : R");
                expVal = Convert.ToDouble(Console.ReadLine());
                expensesValue.Add(expVal);
            }

            /*
             * Asks the user if there are any additional expenses,
             * and if so, prompts the user for the amount of additional expenses
             * will then prompt the user to enter the name of the expense, one by one
             * and will prompt for a value after each expense name input
             */
            Console.Write("\nDo you have any other monthly expenses?\n" +
                "Enter 1 for yes or enter any other key for no : --> ");
            string answer = Console.ReadLine();
            string otherExpns = "";
            int count = 0;
            if (answer.Equals("1"))
            {
                Console.Write("How many other expenses do you have per month? : --> ");
                count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter the name(s) of your other expenses");


                for (int i = 4; i < (count + 4); i++)
                {
                    Console.Write("Expense " + (i - 3) + ". --> ");
                    otherExpns = Console.ReadLine();
                    expenses.Add(otherExpns);
                    //Prints the entered expense and prompts for its value
                    Console.Write("Monthly expenditure on " + expenses[i] + " : R");
                    expVal = Convert.ToDouble(Console.ReadLine());
                    expensesValue.Add(expVal);
                }
            }
            //Sums up all the values in the list that stores the values of the user's expenses
            Expenditure exp = new Expenditure();
            Expenditure.totalExpenses = expensesValue.Sum(x => Convert.ToDouble(x));
        }
}
