using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TEST.View.UserControls
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        bool show = false;
        bool backgroundColor = true;
        public Client()
        {
            InitializeComponent();
            var firstGeneratePassword = GeneratePassword(8);
            passBox.Password = firstGeneratePassword;

            clientTitle.Text = "Youe Credentials";
        }

        private void showPass_Click(object sender, RoutedEventArgs e)
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

            passwordTxtBox.IsEnabled = true;
            passBox.IsEnabled = true;
            generatePass.IsEnabled = true;
            btnVi.Content = imgVi;
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

        private void Vi_Click(object sender, RoutedEventArgs e)
        {
            if (backgroundColor)
            {
                btnVi.Content = "X";
                passBox.IsEnabled = false;
                passwordTxtBox.IsEnabled = false;
                generatePass.IsEnabled = false;
            }
            else if (!backgroundColor)
            {
                btnVi.Content = imgVi;
                passBox.IsEnabled = true;
                passwordTxtBox.IsEnabled = true;
                generatePass.IsEnabled = true;
            }
            backgroundColor = !backgroundColor;
        }
    }
}