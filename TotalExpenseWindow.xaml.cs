using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BudPlan
{
    public partial class TotalExpenseWindow : Window
    {
        //Object creation of the TotalExpense class
        TotalExpense te = new TotalExpense();
        //Delegate to notify the user that their total expenses exceed 75% of their net income
        public delegate void WarningDelegate();
        public TotalExpenseWindow()
        {
            InitializeComponent();

            //Invoking the delegate for the ExpensesValue method from the TotalExpense class
            TotalExpense.ExpensesValueDelegate evd = new TotalExpense.ExpensesValueDelegate(TotalExpense.ExpensesValue);
            evd();

            //Invoking the delegate for the MonthlyAmount method from the TotalExpense class
            TotalExpense.MonthlyAmountDelegate mad = new TotalExpense.MonthlyAmountDelegate(te.MonthlyAmount);
            mad();
        }

        private void viewExp_Click(object sender, RoutedEventArgs e)
        {
            //Displays the list of expenses in descending order
            MessageBox.Show(TotalExpense.viewExpenses);
        }

        private void viewAva_Click(object sender, RoutedEventArgs e)
        {
            //Displays the monthly available money after all deductions
            MessageBox.Show("R" + te.monthlyExpense);

            //Invoking the delegate for the Warning method
            WarningDelegate wd = new WarningDelegate(Warning);
            wd();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            //Clears the expnsVal list
            TotalExpense.expnsVal.Clear();
            TotalExpense.viewExpenses = ""; //Empties the viewExpenses variable

            //Takes the user to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        //Method used to determine if the user's expenses exceed 75% of their net income 
        public static void Warning()
        {
            //Warning notification
            if (TotalExpense.totalExpenses > ((Income.grossIncome - Income.incomeTaxDed) * 0.75))
            {
                MessageBox.Show("=================================================" +
                    "\n---------------------------------- WARNING -----------------------------------\n" +
                    "=================================================" +
                    "\n\tYour monthly expenses exceed 75% of your net income");
            }
        }
    }
}
