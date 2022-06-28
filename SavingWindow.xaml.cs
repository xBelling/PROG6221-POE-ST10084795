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
    public partial class SavingWindow : Window
    {
        Saving sav = new Saving();
        public SavingWindow()
        {
            InitializeComponent();

            //Databinding
            Saving.reason = "Reason";
            Saving.saveTot = 0;
            Saving.time = 0;
            Saving.intRate = 0;

            this.DataContext = sav;
        }

        private void results_Click(object sender, RoutedEventArgs e)
        {
            //Delegate used for calling the MonthlyAmount method from the Saving Window
            Saving.SavingDelegate sd = new Saving.SavingDelegate(sav.MonthlyAmount);
            sd(); //Invoking the delegate

            //Displays the user's monthly saving goal
            MessageBox.Show("The amount needed to save per month to reach the goal of " 
                + Saving.reason + " within " + Saving.time + " months is: R" + Saving.saveAmnt);

            //Takes the user to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
