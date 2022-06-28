using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudPlan
{
    //Inherits the monthlyAmount method from the Expense class
    class HomeLoan : Expense
    {
        public delegate void MonthlyAmountDelegate(); //Delegate to use the MonthlyAmount method in the HomeLoanWindow class
        public static double purchasePrice { get; set; } //Variable to store property purchase price, Get and Set
        public static double deposit { get; set; } //Variable to store deposit on the property, Get and Set
        public static double interest { get; set; } //Variable to store the interest on the repayment, Get and Set
        public static int repayMonths { get; set; } //Variable to store the length of the repayment, Get and Set
        public static double homeLoanRepayment; //Final monthly home loan repayment amount

        //Method that calculates the monthly home loan repayment
        public override void MonthlyAmount()
        {
            double principal;
            double years;
            double total;

            //Calculation of the home loan repayment using formula --> A = P(1 + (i * n))
            principal = purchasePrice - deposit; //Calculates P --> the amount due
            interest = interest / 100; //Calculates the correct format of the interest rate for the formula
            years = repayMonths / 12; //Calculates the home loan repayment period in years

            total = principal * (1 + (interest * years)); //Calculation using the formula

            homeLoanRepayment = total / repayMonths; //Calculates the monthly repayment
            homeLoanRepayment = Math.Round(homeLoanRepayment, 2); //Rounds off to two decimal places
        }
    }
}
