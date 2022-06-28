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
    public partial class HomeLoanWindow : Window
    {
        HomeLoan holo = new HomeLoan();
        public HomeLoanWindow()
        {
            InitializeComponent();

            //Databinding
            HomeLoan.purchasePrice = 0;
            HomeLoan.deposit = 0;
            HomeLoan.interest = 0;
            HomeLoan.repayMonths = 0;

            length.SelectedIndex = 0; //Combobox default selection --> 240 months

            if (length.SelectedIndex == 0)
            {
                HomeLoan.repayMonths = 240;
            }
            else if (length.SelectedIndex == 1)
            {
                HomeLoan.repayMonths = 360;
            }

            this.DataContext = holo;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Lets the user know their values will not be saved if the back button is used
            MessageBox.Show("Values currently on the screen will not be saved");

            //Takes the user to the Accommodation Window
            Accommodation acc = new Accommodation();
            acc.Show();
            this.Close();

            Accommodation.check = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user back to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            //Delegate used to call the MonthlyAmount method from the HomeLoan class
            HomeLoan.MonthlyAmountDelegate mad = new HomeLoan.MonthlyAmountDelegate(holo.MonthlyAmount);
            mad(); //Invoking the delegate

            //Issues an error message if the user's home loan repayment is more than a third of their gross income and displays monthly repayment 
            if (HomeLoan.homeLoanRepayment > (Income.grossIncome / 3))
            {
                MessageBox.Show("=================================================" +
                    "\n-------------------- HOME LOAN APPROVAL IS UNLIKELY ---------------------\n" +
                    "=================================================" +
                    "\nYour monthly home loan payment would exceed a third of your gross income" +
                    "\n---------------------------------------------------------------------------------" +
                    "\n\tYour home loan payment will be: R" + HomeLoan.homeLoanRepayment + " per month");
            }
            //Displays monthly repayment
            else
            {
                MessageBox.Show("Your home loan payment will be: R" + HomeLoan.homeLoanRepayment + " per month");
            }
            
            //Takes the user to the VehiclePrompt Window
            VehiclePrompt vp = new VehiclePrompt();
            vp.Show();
            this.Close();

            //Sets the check to the HomeLoan option
            Accommodation.check = 2;
        }
    }
}
