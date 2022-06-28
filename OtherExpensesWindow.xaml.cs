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
    public partial class OtherExpensesWindow : Window
    {
        Expenditure exp = new Expenditure();
        public OtherExpensesWindow()
        {
            InitializeComponent();

            //Databinding
            Expenditure.otherExpOne = 0;
            Expenditure.otherExpTwo = 0;
            Expenditure.otherExpThree = 0;

            this.DataContext = exp;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            //Takes the user to the dashboard
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Tells the user that the currently entered values will not be saved if the back button is used
            MessageBox.Show("Values currently on the screen will not be saved");

            //Takes the user to the Expenditure Window
            ExpenditureWindow ew = new ExpenditureWindow();
            ew.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            //Stores the other expenses in the expnsVal list if the variable does not equal 0
            if (Expenditure.otherExpOne != 0)
            {
                TotalExpense.expnsVal.Add(Expenditure.otherExpOne);
            }

            if (Expenditure.otherExpTwo != 0)
            {
                TotalExpense.expnsVal.Add(Expenditure.otherExpTwo);
            }

            if (Expenditure.otherExpThree != 0)
            {
                TotalExpense.expnsVal.Add(Expenditure.otherExpThree);
            }

            //Takes the user to the Expenditure Window
            ExpenditureWindow ew = new ExpenditureWindow();
            ew.Show();
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            //Stores the other expenses in the expnsVal list if the variable does not equal 0
            if (Expenditure.otherExpOne != 0)
            {
                TotalExpense.expnsVal.Add(Expenditure.otherExpOne);
            }

            if (Expenditure.otherExpTwo != 0)
            {
                TotalExpense.expnsVal.Add(Expenditure.otherExpTwo);
            }

            if (Expenditure.otherExpThree != 0)
            {
                TotalExpense.expnsVal.Add(Expenditure.otherExpThree);
            }

            //Refreshes the page
            OtherExpensesWindow oew = new OtherExpensesWindow();
            oew.Show();
            this.Close();
        }
    }
}
