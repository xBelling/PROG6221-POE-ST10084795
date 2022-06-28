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
    public partial class VehicleWindow : Window
    {
        Vehicle veh = new Vehicle();
        public VehicleWindow()
        {
            InitializeComponent();

            //Databinding
            Vehicle.makeModel = "Make and Model";
            Vehicle.purchPrice = 0;
            Vehicle.totDeposit = 0;
            Vehicle.intRate = 0;
            Vehicle.insurancePrem = 0;

            this.DataContext = veh;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Tells the user that the currently entered values will not be stored
            MessageBox.Show("Values currently on the screen will not be saved");

            //Takes the user to the VehiclePrompt Window
            VehiclePrompt vp = new VehiclePrompt();
            vp.Show();
            this.Close();

            Vehicle.check = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            //Sets the vehicle check to the buying a vehicle option
            Vehicle.check = 1;

            //Delegate used to call the MonthlyAmount method from the Vehicle class
            Vehicle.monthlyAmountDelegate mad = new Vehicle.monthlyAmountDelegate(veh.MonthlyAmount);
            mad(); //Invoking the delegate

            //Displays the monthly vehicle repayment
            MessageBox.Show("Your payment for the " + Vehicle.makeModel + " will be: R" + Vehicle.vehicleRepay + " per month");

            //Takes the user to the TotalExpense Window
            TotalExpenseWindow tew = new TotalExpenseWindow();
            tew.Show();
            this.Close();
        }
    }
}
