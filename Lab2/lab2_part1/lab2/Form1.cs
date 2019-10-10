using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        double a_2 = 0, b_2 = 0, c_2 = 0, x1_2 = 0, x2_2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Calculating functions
        public bool calculate(double a, double b, double c, ref double x1, ref double x2)
        {
            double discriminant_val;

            discriminant_val = discriminant_calc(a, b, c);

            if (discriminant_val > 0)
            {
                x1 = x1_calc(a, b, discriminant_val);
                x2 = x2_calc(a, b, discriminant_val);

                return true;
            }
            else if (discriminant_val == 0)
            {
                x1 = x2 = x1_calc(a, b, discriminant_val);

                return true;
            }
            else
            {
                return false;
            }
        }
        public double discriminant_calc(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        public double x1_calc(double a, double b, double discriminant_val)
        {
            return ((-b + Math.Sqrt(discriminant_val)) / (2 * a));
        }
        public double x2_calc(double a, double b, double discriminant_val)
        {
            return ((-b - Math.Sqrt(discriminant_val)) / (2 * a));
        }
        
        //Action functions
        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;
            try
            {
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);
                c = Double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

            if (calculate(a, b, c, ref x1, ref x2))
            {
                x1 = Math.Round(x1, 4);
                x2 = Math.Round(x2, 4);

                label6.Text = x1.ToString();
                label7.Text = x2.ToString();
            }
            else
            {
                label6.Text = "No answer";
                label7.Text = "No answer";
            }
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a_2 = Double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в поле \"a=\"");
                textBox6.Clear();
            }

            if (calculate(a_2, b_2, c_2, ref x1_2, ref x2_2))
            {
                x1_2 = Math.Round(x1_2, 4);
                x2_2 = Math.Round(x2_2, 4);

                label8.Text = x1_2.ToString();
                label9.Text = x2_2.ToString();
            }
            else
            {
                label8.Text = "No answer";
                label9.Text = "No answer";
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b_2 = Double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в поле \"b=\"");
                textBox6.Clear();
            }

            if (calculate(a_2, b_2, c_2, ref x1_2, ref x2_2))
            {
                x1_2 = Math.Round(x1_2, 4);
                x2_2 = Math.Round(x2_2, 4);

                label8.Text = x1_2.ToString();
                label9.Text = x2_2.ToString();
            }
            else
            {
                label8.Text = "No answer";
                label9.Text = "No answer";
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c_2 = Double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в поле \"c=\"");
                textBox6.Clear();
            }

            if (calculate(a_2, b_2, c_2, ref x1_2, ref x2_2))
            {
                x1_2 = Math.Round(x1_2, 4);
                x2_2 = Math.Round(x2_2, 4);

                label8.Text = x1_2.ToString();
                label9.Text = x2_2.ToString();
            }
            else
            {
                label8.Text = "No answer";
                label9.Text = "No answer";
            }
        }
    }
}
