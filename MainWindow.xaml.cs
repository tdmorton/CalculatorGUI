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

namespace CalculatorGUI
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button) sender;
            numberBlock.Text = b.Content.Text;
        }

        private void BtnEq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}