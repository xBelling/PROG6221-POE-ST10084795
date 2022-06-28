using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudPlan
{
    internal class Saving : Expense
    {
        public delegate void SavingDelegate();
        public static double saveAmnt; //Variable used to store the monthly saving
        public static double saveTot { get; set; } //Variable used to store the total saving value, Get and Set
        public static double time { get; set; } //Variable used to store the time to reach the goal, Get and Set
        public static string reason { get; set; } //Variable used to store the specified reason for the saving, Get and Set
        public static double intRate { get; set; } //Variable used to store the interest rate, Get and Set

        //Method that calculates the monthly Savings Amount
        public override void MonthlyAmount()
        {
            double years;

            //Calculation of the monthly saving using formula --> P = A/(1 + (i * n))
            intRate = intRate / 100; //Calculates the correct format of the interest rate for the formula
            years = time / 12; //Calculates the period in years
            
            saveAmnt = saveTot /(1 + intRate * years);//Calculation using the formula
            saveAmnt = saveAmnt / time; //Calculates the monthly saving
            saveAmnt = Math.Round(saveAmnt, 2); //Rounds off to two decimal places
        }
    }
}
