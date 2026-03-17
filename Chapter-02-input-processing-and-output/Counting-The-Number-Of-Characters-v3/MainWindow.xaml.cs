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

namespace Counting_The_Number_Of_Characters_v3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string UserInputPlaceholder = "Input anything eg. alphanumerals and special characters";
        public MainWindow()
        {
            InitializeComponent();

            // set placeholder AFTER controls are created
            userInput.Text = UserInputPlaceholder;
            userInput.Foreground = new SolidColorBrush(Colors.Gray);

            UpdateCount();
        }

        private void UserInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (userInput.Text == UserInputPlaceholder)
            {
                userInput.Text = "";
                userInput.Foreground = new SolidColorBrush(Colors.Black);
            }

            UpdateCount();
        }

        private void UserInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userInput.Text))
            {
                userInput.Text = UserInputPlaceholder;
                userInput.Foreground = new SolidColorBrush(Colors.Gray);
            }

            UpdateCount();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCount();
        }

        private void UpdateCount()
        {
            if (count == null)
                return;
            var textToCount = userInput.Text == UserInputPlaceholder ? string.Empty : userInput.Text ?? string.Empty;
            int length = textToCount.Length;
            count.Text = length.ToString();
        }


    }
}