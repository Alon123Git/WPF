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

namespace TEST.Windows
{
    /// <summary>
    /// Interaction logic for Server.xaml
    /// </summary>
    public partial class Server : Window
    {
        bool show = false;

        #region constructior
        public Server()
        {
            InitializeComponent();
        }
        #endregion

        #region buttons events

        #region show password
        /// <summary>
        /// Show password when click
        /// </summary>
        private void showPass_Click(object sender, RoutedEventArgs e)
        {
            if (show)
            {
                passBox.Password = passwordTxtBox.Text;
                passwordTxtBox.Visibility = Visibility.Collapsed;
                passBox.Visibility = Visibility.Visible;
            }

            else if (!show)
            {
                passwordTxtBox.Text = passBox.Password;
                passBox.Visibility = Visibility.Collapsed;
                passwordTxtBox.Visibility = Visibility.Visible;
            }
            show = !show;
        }
        #endregion

        #region clear user name
        /// <summary>
        /// Empty the user name text
        /// </summary>
        private void ClearUserName_Click(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = "";
        }
        #endregion

        #region clear password
        /// <summary>
        /// Empty the password text
        /// </summary>
        private void ClearPasword_Click(object sender, RoutedEventArgs e)
        {
            passBox.Password = "";
            passwordTxtBox.Text = "";
        }
        #endregion

        #endregion

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new();
            mn.Show();
            Close();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SignUp su = new();
            su.Show();
            Close();
        }
    }
}
