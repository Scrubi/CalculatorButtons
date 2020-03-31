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

namespace WPFCalculator2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;

        private void one_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "4";
        }
        private void five_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "5";
        }
        private void six_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "6";
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "7";
        }
        private void eight_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "8";
        }
        private void nine_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = calculate.Text + "0";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(calculate.Text);
            calculate.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void ero_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(calculate.Text);
            calculate.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void kerto_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(calculate.Text);
            calculate.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void jako_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(calculate.Text);
            calculate.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(calculate.Text);
                calculate.Text = total2.ToString();
                total1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(calculate.Text);
                calculate.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(calculate.Text);
                calculate.Text = total2.ToString();
                total1 = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(calculate.Text);
                calculate.Text = total2.ToString();
                total1 = 0;
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text = "";
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            calculate.Text += ",";
        }
    }
}
