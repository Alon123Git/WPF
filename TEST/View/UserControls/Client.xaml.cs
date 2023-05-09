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
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        public Client()
        {
            InitializeComponent();

            clientTitle.Text = "Youe Credentials";
        }

        private void btnAcceptAll_Click(object sender, RoutedEventArgs e)
        {
            //if (revealModeCheckBox.IsChecked == true)
            //{
            //    passwordBox1.PasswordRevealMode = PasswordRevealMode.Visible;
            //}
            //else
            //{
            //    passwordBox1.PasswordRevealMode = PasswordRevealMode.Hidden;
            //}
        }
    }
}
