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

namespace FinalCalulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _units;

        public MainWindow()
        {
            InitializeComponent();
            InitializeWindowsElements();
        }

        private void InitializeWindowsElements()
        {
            _units = "¢";

            lbl_Pennies.Content = "Pennies (" + _units + ")";
            lbl_Nickles.Content = "Nickles (" + _units + ")";
            lbl_Dimes.Content = "Dimes (" + _units + ")";
            lbl_Quarters.Content = "Quarters (" + _units + ")";
            lbl_Total.Content = "Total Amount (" + _units + ")";

        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            double total;

            total = double.Parse(txtbox_Pennies.Text) + double.Parse(txtbox_Nickles.Text) + double.Parse(txtbox_Dimes.Text) + double.Parse(txtbox_Quarters.Text);

            txtbox_Total.Text = total;

            SolutionWindow solutionWindow = new SolutionWindow(total);

            solutionWindow.ShowDialog();
        }

    }

}
