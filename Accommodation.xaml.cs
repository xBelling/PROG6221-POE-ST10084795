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
    public partial class Accommodation : Window
    {
        public static int check { get; set; } //Holds whether the user uses the buying or renting a property option
        public Accommodation()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the previous window --> Expenditure Window
            ExpenditureWindow ew = new ExpenditureWindow();
            ew.Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user back to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void rent_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the Rental Window
            RentalWindow rw = new RentalWindow();
            rw.Show();
            this.Close();
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the HomeLoan Window
            HomeLoanWindow hlw = new HomeLoanWindow();
            hlw.Show();
            this.Close();
        }
    }
}
