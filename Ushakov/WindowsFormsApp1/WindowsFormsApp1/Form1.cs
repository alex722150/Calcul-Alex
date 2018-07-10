using System;
using System.Windows.Forms;
using WindowsFormsApp1.TwoArguments;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            string operation = ((Button)sender).Name;
            ITwoArgumentsCalculate calculator = TwoArgumentFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstValue, secondValue);

            label1.Text = result.ToString();

        }

        private void Squaring_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string operation = ((Button)sender).Name;
            IOneArgumentCalculate calculator = OneArgumentFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstValue);

            label1.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

