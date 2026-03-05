using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FirstNumberPlaceholder = "First Number";
        private const string SecondNumberPlaceholder = "Second Number";
        private const string SumPlaceholder = "Sum";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Text == FirstNumberPlaceholder)
            {
                firstNumber.Text = "";
                firstNumber.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void FirstNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNumber.Text))
            {
                firstNumber.Text = FirstNumberPlaceholder;
                firstNumber.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void SecondNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (secondNumber.Text == SecondNumberPlaceholder)
            {
                secondNumber.Text = "";
                secondNumber.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void SecondNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(secondNumber.Text))
            {
                secondNumber.Text = SecondNumberPlaceholder;
                secondNumber.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstNumber.Text == FirstNumberPlaceholder || secondNumber.Text == SecondNumberPlaceholder)
                {
                    MessageBox.Show("Please enter valid numbers in both fields.", "Input Error");
                    return;
                }

                var num1 = decimal.Parse(firstNumber.Text);
                var num2 = decimal.Parse(secondNumber.Text);
                var result = num1 + num2;
                sum.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Invalid Input");
            }
        }
    }
}