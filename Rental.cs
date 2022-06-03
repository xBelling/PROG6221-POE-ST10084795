using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApp
{
    //Inherits the monthlyAmount method from the Expense class
    class Rental : Expense
    {
        public static double rentalPayment { get; set; } //Get and Set

        //Method that gets the user's monthly rental fee
        public override void MonthlyAmount()
        {
            try
            {
                Console.Write("Enter the monthly rental fee : --> R");
                rentalPayment = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Please enter a valid rental fee amount : --> R");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                rentalPayment = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
