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
            //lblId.Content = "Your ID: ";
            //lblPas.Content = "Your Password";
            //btnAccept.Content = "Accept All";
            //btnManage.Content = "Management Only";
        }
    }
}
