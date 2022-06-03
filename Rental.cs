using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApplication
{
    //Inherits the monthlyAmount method from the Expense class
    class Rental : Expense
    {
        public static double rentalPayment { get; set; } //Get and Set

        //Method that gets the user's monthly rental fee
        public override void MonthlyAmount()
        {
            Console.Write("Enter the monthly rental fee : --> R");
            rentalPayment = Convert.ToDouble(Console.ReadLine());
        }
    }
}
