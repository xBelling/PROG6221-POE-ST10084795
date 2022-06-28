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
    public partial class ExpenditureWindow : Window
    {
        Expenditure exp = new Expenditure();
        public ExpenditureWindow()
        {
            InitializeComponent();

            //Databinding
            Expenditure.expValOne = 0;
            Expenditure.expValTwo = 0;
            Expenditure.expValThree = 0;
            Expenditure.expValFour = 0;

            this.DataContext = exp;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user back to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void otherExpns_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the OtherExpenses Window
            OtherExpensesWindow oew = new OtherExpensesWindow();
            oew.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the Accommodation Window
            Accommodation acc = new Accommodation();
            acc.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the Income Window
            IncomeWindow iw = new IncomeWindow();
            iw.Show();
            this.Close();
        }
    }
}
