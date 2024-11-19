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

        private static string Extract_Text(object sender)
        {
            Button b = (Button)sender;
            return b.Content.ToString();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            numberBlock.Text += Extract_Text(sender);
        }

        private void BtnEq_Click(object sender, RoutedEventArgs e)
        {
            equationBlock.Text += numberBlock.Text;
        }

        private void BtnOp_Click(object sender, RoutedEventArgs e)
        {
            equationBlock.Text += numberBlock.Text;
            equationBlock.Text += " " + Extract_Text(sender) + " ";
        }

        private void BtnPM_Click(object sender, RoutedEventArgs e)
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