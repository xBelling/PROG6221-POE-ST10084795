using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudPlan
{
    //Inherits the monthlyAmount method from the Expense class
    internal class Vehicle : Expense
    {
        public delegate void monthlyAmountDelegate();
        public static string makeModel { get; set; }
        public static double purchPrice { get; set; }
        public static double totDeposit { get; set; }
        public static double intRate { get; set; }
        public static double insurancePrem { get; set; }
        public static double vehicleRepay;
        public static int check;
        public override void MonthlyAmount()
        {
            double principalAmnt;

            //Calculation of the vehicle repayment using formula --> A = P(1 + (i * n))
            principalAmnt = purchPrice - totDeposit; //Calculates P --> the amount due
            intRate = intRate / 100; //Calculates the correct format of the interest rate for the formula

            //Calculation using the formula, the repayment period (n) is assumed as 5 years for all vehicles
            vehicleRepay = principalAmnt * (1 + (intRate * 5));
            vehicleRepay = vehicleRepay / 60; //Divided by 60 to get the monthly repayment
            vehicleRepay += insurancePrem; //Insurance premium is added
            vehicleRepay = Math.Round(vehicleRepay, 2); //Rounds off to two decimal places
        }
    }
}
