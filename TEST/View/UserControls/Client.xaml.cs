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

        private void CleanPass_Click(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = "";
            passBox.Password = "";
        }

        private void CleanId_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
        }
    }
}
