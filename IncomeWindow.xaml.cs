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
    public partial class IncomeWindow : Window
    {
        Income inc = new Income();
        public IncomeWindow()
        {
            InitializeComponent();

            //Databinding
            Income.grossIncome = 0;
            Income.incomeTaxDed = 0;

            this.DataContext = inc;
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
            //Takes the user to the Exenditure Window
            ExpenditureWindow ew = new ExpenditureWindow();
            ew.Show();
            this.Close();
        }
    }
}
