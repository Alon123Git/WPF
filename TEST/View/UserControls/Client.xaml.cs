using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TEST.View.UserControls
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        bool show = false;
        public Client()
        {
            InitializeComponent();

            clientTitle.Text = "Youe Credentials";
        }

        private void btnAcceptAll_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (show)
            {
                passBox.Password = passwordTxtBox.Text;
                passwordTxtBox.Visibility = Visibility.Collapsed;
                passBox.Visibility = Visibility.Visible;
            }

            if (!show)
            {
                passwordTxtBox.Text = passBox.Password;
                passBox.Visibility = Visibility.Collapsed;
                passwordTxtBox.Visibility = Visibility.Visible;
            }
            show = !show;
        }

        /// <summary>
        /// Empty the password method
        /// </summary>
        private void CleanPass_Click(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = "";
            passBox.Password = "";
        }

        /// <summary>
        /// Empty the text id method
        /// </summary>
        private void CleanId_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
        }

        private void RandomPassword_Click(object sender, RoutedEventArgs e)
        {
            passBox.Password = GeneratePassword(8);
            passwordTxtBox.Text = GeneratePassword(8);
        }

        public string GeneratePassword(int length)
        {
            // Define a regular expression pattern to match the password.
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";

            // Generate a new random password until it matches the pattern.
            Random rand = new Random();
            string password;
            do
            {
                // Generate a new password of the specified length.
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                password = new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
            } while (!Regex.IsMatch(password, pattern));

            return password;
        }
    }
}