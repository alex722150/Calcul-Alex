using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gonashapelg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       


    private void button1_Click(object sender, EventArgs e)
        {
            double firstnum = Convert.ToDouble(textBox4.Text);
            double secondnum = Convert.ToDouble(textBox5.Text);
            double result;

            switch (((Button)sender).Name)
            {
                case "button1":
                    result = firstnum + secondnum;
                    break;
                case "button2":
                    result = firstnum - secondnum;
                    break;
                case "button3":
                    result = firstnum * secondnum;
                    break;
                case "button4":
                    result = firstnum / secondnum;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }



            textBox6.Text = result.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }
    }
}
