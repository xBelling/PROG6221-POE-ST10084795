using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudPlan
{
    //Inherits the MonthlyAmount method and the monthlyExpense variable from the Expense class
    internal class TotalExpense : Expense
    {
        //List to store the values of the user's expenses
        public static List<double> expnsVal = new List<double>();
        //Delegate for the use of the ExpensesValue method in the TotalExpenseWindow class
        public delegate void ExpensesValueDelegate();
        //Variable used to store the output for the monthly expenses view button
        public static string viewExpenses;
        //Variable used to store the value of the sum of the expenses
        public static double totalExpenses;
        //Delegate for the use of the MonthlyAmount method in the TotalExpenseWindow class
        public delegate void MonthlyAmountDelegate();

        public static void ExpensesValue()
        {
            //Adding the expenses from other classes to the list
            if (Expenditure.expValOne != 0)
            {
                expnsVal.Add(Expenditure.expValOne);
            }

            if (Expenditure.expValTwo != 0)
            {
                expnsVal.Add(Expenditure.expValTwo);
            }

            if (Expenditure.expValThree != 0)
            {
                expnsVal.Add(Expenditure.expValThree);
            }

            if (Expenditure.expValFour != 0)
            {
                expnsVal.Add(Expenditure.expValFour);
            }

            if (Accommodation.check == 1 && Rental.rentalPayment != 0)
            {
                //If the user chose to rent accommodation, the rent payment is added to the list
                expnsVal.Add(Rental.rentalPayment);
            }
            else if (Accommodation.check == 2 && HomeLoan.homeLoanRepayment != 0)
            {
                //If the user chose to buy a house, the home loan payment is added to the list
                expnsVal.Add(HomeLoan.homeLoanRepayment);
            }
            
            if (Vehicle.check == 1 && Vehicle.vehicleRepay != 0)
            {
                //If the user chose to buy a vehicle, the vehicle payment is added to the list
                expnsVal.Add(Vehicle.vehicleRepay);
            }

            //Sorting the list into descending order
            expnsVal.Sort();
            expnsVal.Reverse();

            for (int i = 0; i < expnsVal.Count; i++)
            {
                viewExpenses += ("R" + expnsVal[i] + "\n");
            }
        }

        //Method that calculates the total available money after all deductions
        public override void MonthlyAmount()
        {
            //Sums up all the values in the list that stores the values of the user's expenses
            totalExpenses = expnsVal.Sum(x => Convert.ToDouble(x));
            totalExpenses = Math.Round(totalExpenses, 2);

            //Available money calculation
            monthlyExpense = Income.grossIncome - (Income.incomeTaxDed + totalExpenses);
            monthlyExpense = Math.Round(monthlyExpense, 2); //Rounds off the available money to two decimal places
        }
    }
}
