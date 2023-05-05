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

namespace TEST.View.UserControls
{
    /// <summary>
    /// Interaction logic for Server.xaml
    /// </summary>
    public partial class Server : UserControl
    {
        public Server()
        {
            InitializeComponent();

            serverTitle.Text = "Login to the server";
            txbUserName.Text = "User Name";
            //btnLogin.Content = "Login";
            //txtBnoAccount.Text = "Don't have an account?";
            //signUpLink.Text = "Sign Up";
        }
    }
}
