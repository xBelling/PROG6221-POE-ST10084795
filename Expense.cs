using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerApplication
{
    //Abstract class
    abstract class Expense
    {
        public double monthlyExpense;

        //Abstract method
        public abstract void MonthlyAmount();
    }
}
