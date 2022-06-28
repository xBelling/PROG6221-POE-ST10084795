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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudPlan
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MouseClick(Object sender, MouseButtonEventArgs e)
        {
            //To handle mouse click events
        }

        private void budget(object sender, RoutedEventArgs e)
        {
            //If the user chooses the budget planner option, the first window of the budget planner sequence will be shown
            IncomeWindow iw = new IncomeWindow();
            iw.Show();
            this.Close();
        }

        private void saving(object sender, RoutedEventArgs e)
        {
            //If the user chooses the budget planner option, the Savings window will be shown
            SavingWindow sw = new SavingWindow();
            sw.Show();
            this.Close();
        }
    }
}
