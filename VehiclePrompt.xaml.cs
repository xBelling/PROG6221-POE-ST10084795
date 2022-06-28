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
    public partial class VehiclePrompt : Window
    {
        public VehiclePrompt()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user back to the Accommodation Window
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

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the Vehicle Window
            VehicleWindow vw = new VehicleWindow();
            vw.Show();
            this.Close();
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the TotalExpense Window
            TotalExpenseWindow tew = new TotalExpenseWindow();
            tew.Show();
            this.Close();
        }
    }
}
