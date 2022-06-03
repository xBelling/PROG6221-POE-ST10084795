using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApp
{
    //Inherits the monthlyAmount method from the Expense class
    internal class Vehicle : Expense
    {
        public static double vehicleRepay { get; set; }
        public override void MonthlyAmount()
        {
            double principalAmnt;

            //Prompting the user for Vehicle information
            Console.Write("Enter the following information regarding the vehicle:" +
                "\nMake and Model: --> ");
            string makeModel = Console.ReadLine();
            Console.Write("Purchase Price: --> R");
            double purchPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Total Deposit: --> R");
            double totDeposit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Interest Rate as a percantage (Format : 7.5% --> 7,5) : --> ");
            double intRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Estimated Insurance Premium: --> R");
            double insurancePrem = Convert.ToDouble(Console.ReadLine());

            //Calculation of the vehicle repayment using formula --> A = P(1 + (i * n))
            principalAmnt = purchPrice - totDeposit; //Calculates P --> the amount due
            intRate = intRate / 100; //Calculates the correct format of the interest rate for the formula

            //Calculation using the formula, the repayment period (n) is assumed as 5 years for all vehicles
            vehicleRepay = principalAmnt * (1 +(intRate * 5));
            vehicleRepay = vehicleRepay / 60; //Divided by 60 to get the monthly repayment
            vehicleRepay += insurancePrem; //Insurance premium is added
            vehicleRepay = Math.Round(vehicleRepay, 2); //Rounds off to two decimal places
        }
    }
}
