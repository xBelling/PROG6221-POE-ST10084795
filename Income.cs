using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApp
{
    //Inherits the MonthlyAmount method from the Expense class
    class Income : Expense
    {
        //Gets and Sets
        public static double incomeTaxDed { get; set; }
        public static double grossIncome { get; set; }

        //Method that prompts the user for income and tax deduction on the income
        public override void MonthlyAmount()
        {
            try
            {
                Console.Write("Enter your gross monthly income : --> R");
                grossIncome = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Please enter a valid income amount : --> R");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                grossIncome = Convert.ToDouble(Console.ReadLine());
            }
            try
            {
                Console.Write("Enter your estimated monthly income tax deduction : --> R");
                incomeTaxDed = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Please enter a valid income tax deduction amount : --> R");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                incomeTaxDed = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
