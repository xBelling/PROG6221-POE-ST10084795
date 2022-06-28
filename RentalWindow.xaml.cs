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
    public partial class RentalWindow : Window
    {
        Rental ren = new Rental();
        public RentalWindow()
        {
            InitializeComponent();

            //Databinding
            Rental.rentalPayment = 0;

            this.DataContext = ren;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Tells the user that the values currently on the window will not be saved
            MessageBox.Show("Values currently on the screen will not be saved");

            //Takes the user to the Accommodation Window
            Accommodation acc = new Accommodation();
            acc.Show();
            this.Close();
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
            //Takes the user to the VehiclePrompt Window
            VehiclePrompt vp = new VehiclePrompt();
            vp.Show();
            this.Close();
            Accommodation.check = 1;
        }
    }
}
