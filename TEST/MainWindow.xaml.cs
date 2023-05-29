using System.Windows;
using TEST.Windows;

namespace TEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Client cl = new();
            cl.Show();
            Close();
        }

        private void Server_Click(object sender, RoutedEventArgs e)
        {
            Server serve = new();
            serve.Show();
            Close();
        }
    }
}