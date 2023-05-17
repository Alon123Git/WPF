using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TEST.Validation;

namespace TEST.View.UserControls
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        #region varibles
        bool show = false;
        bool viToggle = true;
        #endregion

        #region constructor
        public Client()
        {
            InitializeComponent();
            var firstGeneratePassword = GeneratePassword(8);
            passBox.Password = firstGeneratePassword;
            var firstGenerateID = GenerateId();
            txtId.Text = firstGenerateID;
            clientTitle.Text = "Youe Credentials";
        }
        #endregion

        #region buttons events
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
            passCleaner();
            passwordTxtBox.Text = "";
            passBox.Password = "";
        }

        /// <summary>
        /// Empty the text id method
        /// </summary>
        private void CleanId_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            passCleaner();
        }

        /// <summary>
        /// generate random password
        /// </summary>
        private void RandomPassword_Click(object sender, RoutedEventArgs e)
        {
            passBox.Password = GeneratePassword(8);
            passwordTxtBox.Text = GeneratePassword(8);
        }

        /// <summary>
        /// generate random id
        /// </summary>
        private void RandomId_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = GenerateId();
        }
        #endregion

        #region generate random password
        /// <summary>
        /// generate random password
        /// </summary>
        /// <param name="length">length</param>
        /// <returns>string (generate password)</returns>
        public string GeneratePassword(int length)
        {
            // Define a regular expression pattern to match the password.
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,8}$";

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
        #endregion

        #region V button
        /// <summary>
        /// disable the password text box, and show validation message if needed
        /// </summary>
        private void Vi_Click(object sender, RoutedEventArgs e)
        {
            bool valid = false;
            bool validId = false;

            if (passBox.Visibility == Visibility.Visible)
            {
                valid = ValidServe.validPass(passBox.Password, ValidServe.TxtType.PASSWORD);
            }
            else
            {
                valid = ValidServe.validPass(passwordTxtBox.Text, ValidServe.TxtType.PASSWORD);
            }
            validId = ValidServe.validPass(txtId.Text, ValidServe.TxtType.ID);
            if (!valid || !validId)
            {
                if (!valid && !validId) {
                    txbValid.Visibility = Visibility.Visible;
                    txbValPassword.Visibility = Visibility.Visible;
                }
                else if(valid)
                {
                    txbValid.Visibility = Visibility.Visible;
                    txbValPassword.Visibility = Visibility.Collapsed;
                }
                else
                {
                    // if the password is not valid, enable the text box and password box to write the password again
                    passwordTxtBox.IsEnabled = true;
                    passBox.IsEnabled = true;
                    txbValid.Visibility = Visibility.Collapsed;
                    txbValPassword.Visibility = Visibility.Visible; // validation message is visible 
                }
                if (btnVi.Content != "X")
                {
                    MessageBox.Show("Password or id is not valid", "Error Message", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            if (viToggle && valid && validId)
            {
                txbValid.Visibility = Visibility.Collapsed;
                txbValPassword.Visibility = Visibility.Collapsed;
                btnVi.Content = "X";
                passBox.IsEnabled = false;
                passwordTxtBox.IsEnabled = false;
                generatePass.IsEnabled = false;
                generateId.IsEnabled = false;
                txtId.IsEnabled = false;
            }
            else if (!viToggle)
            {
                btnVi.Content = imgVi;
                passBox.IsEnabled = true;
                passwordTxtBox.IsEnabled = true;
                generatePass.IsEnabled = true;
                generateId.IsEnabled = true;
                txtId.IsEnabled = true;
            }
            viToggle = !viToggle;
        }
        #endregion

        #region generate id
            /// <summary>
            /// generate random id 
            /// </summary>
            /// <returns>string (generate id)</returns>
            private string GenerateId()
            {
                int randomIndex = 0; // init varible
                string randomElement = ""; // init varible
                Random rnd = new();
                string idNums = "0 1 2 3 4 5 6 7 8 9"; //string to choice from
                string[] idNumsArr = idNums.Split(" ").ToArray(); //convert string to array
                string finalId = "";
                for (int i = 0; i < idNumsArr.Length-1; i++) // creating generated string char by char
                {
                    randomIndex = rnd.Next(0, idNumsArr.Length);
                    randomElement = idNumsArr[randomIndex];
                    finalId += randomElement;
                }
                return finalId; //9 digit generated string
            }
        #endregion

        #region passCleaner
        private void passCleaner()
        {
            generateId.IsEnabled = true;
            passwordTxtBox.IsEnabled = true;
            passBox.IsEnabled = true;
            generatePass.IsEnabled = true;
            btnVi.Content = imgVi;
            txtId.IsEnabled = true;
        }
        #endregion
    }
}