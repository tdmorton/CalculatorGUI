using System.CodeDom.Compiler;
using System.Reflection.PortableExecutable;
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

        private string lastVal = String.Empty;
        private string lastOp = String.Empty;
        private bool clrNumFlag = true;
        private bool clrEqFlag = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private string Result(string operation, string lastVal, string currentVal)
        {
            decimal result = 0;
                switch (operation)
                {
                case "+":
                    result = Convert.ToDecimal(lastVal) + Convert.ToDecimal(currentVal);
                    break;
                case "-":
                    result = Convert.ToDecimal(lastVal) - Convert.ToDecimal(currentVal);
                    break;
                case "*":
                    result = Convert.ToDecimal(lastVal) * Convert.ToDecimal(currentVal);
                    break;
                case "/":
                    result = Convert.ToDecimal(lastVal) / Convert.ToDecimal(currentVal);
                    break;
                default:
                    result = Convert.ToDecimal(currentVal);
                    break;
                }
            return Convert.ToString(result);
        }
            

        private void opEquation()
        {
            if (equationBlock.Text.Contains("=") || equationBlock.Text.Contains("+") || equationBlock.Text.Contains("-") || equationBlock.Text.Contains("*") || equationBlock.Text.Contains("/"))
            {
                equationBlock.Text = "";
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (clrNumFlag)
            {
                numberBlock.Text = "0";
                clrNumFlag = false;
            }
            if (clrEqFlag)
            {
                equationBlock.Text = "";
                clrEqFlag = false;
            }
            if (numberBlock.Text == "0")
            {
                numberBlock.Text = "";
            }

            numberBlock.Text += ((Button)sender).Content.ToString();
        }

        private void BtnEq_Click(object sender, RoutedEventArgs e)
        {
            equationBlock.Text += numberBlock.Text + " =";
            numberBlock.Text = Result(lastOp, lastVal, numberBlock.Text);
            clrNumFlag = true;
            clrEqFlag = true;
        }

        private void BtnOp_Click(object sender, RoutedEventArgs e)
        {
            opEquation();
            equationBlock.Text += numberBlock.Text;
            equationBlock.Text += " " + ((Button)sender).Content + " ";
            lastVal = numberBlock.Text;
            lastOp = ((Button)sender).Content.ToString();
            clrNumFlag = true;
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

        private void BtnPer_Click(object sender, RoutedEventArgs e)
        {
            if (numberBlock.Text.Contains("."))
            {
                return;
            }
            Btn1_Click(sender, e);
        }
    }
    public interface IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2);
    }
    public class Sum:IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2)
        {
            return val1 + val2;
        }
    }
    public class Sub : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2)
        {
            return val1 - val2;
        }
    }
    public class Mult : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2)
        {
            return val1 * val2;
        }
    }
    public class Div : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2)
        {
            return val1 / val2;
        }
    }
}