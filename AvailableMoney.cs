using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApplication
{
    //Inherits the MonthlyAmount method and the monthlyExpense varaible from the Expense class
    class AvailableMoney : Expense
    {
        //Method that calculates the total available money after all deductions
        public override void MonthlyAmount()
        {
            //Available money calculation
            monthlyExpense = Income.grossIncome - (Income.incomeTaxDed + Rental.rentalPayment + HomeLoan.homeLoanRepayment + Expenditure.totalExpenses);
            monthlyExpense = Math.Round(monthlyExpense, 2); //Rounds off the available money to two decimal places

            Console.WriteLine("Your monthly income after all deductions : R" + monthlyExpense); //Prints the available money amount
        }
    }
}
