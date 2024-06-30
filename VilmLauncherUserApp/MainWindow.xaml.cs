using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VilmLauncherUserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aga = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            aga = aga + 1;
            string agaS = aga.ToString();
            TextBox1.Text = agaS;
        }
    }

}