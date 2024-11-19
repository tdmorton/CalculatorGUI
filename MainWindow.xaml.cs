using System.CodeDom.Compiler;
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

        private string Extract_Text(object sender)
        {
            Button b = (Button)sender;
            return b.Content.ToString();
        }

        private string result()
        {
            string[] ops = new string[10];
            double sum = 0.0;
            string[] words = equationBlock.Text.Split(" ");
            sum += Convert.ToDouble(words[0]);
            for (int i=2; i < words.Length; i+=2)
            {
                switch (words[i])
                {
                    case "+":
                        sum += Convert.ToDouble(words[i]);
                        break;
                    case "-":
                        sum -= Convert.ToDouble(words[i]);
                        break;
                    case "*":
                        sum *= Convert.ToDouble(words[i]);
                        break;
                    case "/":
                        sum /= Convert.ToDouble(words[i]);
                        break;
                }
            }
            return Convert.ToString(sum);
        }

        private bool opFlag()
        {
            static bool opflag = false;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            numberBlock.Text += Extract_Text(sender);
        }

        private void BtnEq_Click(object sender, RoutedEventArgs e)
        {
            equationBlock.Text += numberBlock.Text + " =";
            numberBlock.Text = result();
        }

        private void BtnOp_Click(object sender, RoutedEventArgs e)
        {
            equationBlock.Text += numberBlock.Text;
            equationBlock.Text += " " + Extract_Text(sender) + " ";
            numberBlock.Text = "";
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