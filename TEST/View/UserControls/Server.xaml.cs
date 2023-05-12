using System;
using System.Collections.Generic;
using System.Drawing;
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
using Brushes = System.Windows.Media.Brushes;

namespace TEST.View.UserControls
{
    /// <summary>
    /// Interaction logic for Server.xaml
    /// </summary>
    public partial class Server : UserControl
    {
        bool show = false;
        public Server()
        {
            InitializeComponent();

            serverTitle.Text = "Login to the server";
        }

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

        /// <summary>
        /// Empty the user name text
        /// </summary>
        private void ClearUserName_Click(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = "";
        }

        /// <summary>
        /// Empty the password text
        /// </summary>
        private void ClearPasword_Click(object sender, RoutedEventArgs e)
        {
            passBox.Password = "";
            passwordTxtBox.Text = "";
        }
    }
}