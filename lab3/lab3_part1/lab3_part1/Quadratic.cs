using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_part1
{
    public partial class Quadratic : Form
    {
        public Quadratic()
        {
            InitializeComponent();
        }

        public bool calculate(double a, double b, double c, ref double dis, ref double x1, ref double x2)
        {
            dis = discriminant_calc(a, b, c);

            if (dis > 0)
            {
                x1 = x1_calc(a, b, dis);
                x2 = x2_calc(a, b, dis);

                return true;
            }
            else if (dis == 0)
            {
                x1 = x2 = x1_calc(a, b, dis);

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
        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, dis = 0, x1 = 0, x2 = 0;
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

            
            if (calculate(a, b, c, ref dis, ref x1, ref x2))
            {
                x1 = Math.Round(x1, 5);
                x2 = Math.Round(x2, 5);

                textBox5.Text = x1.ToString();
                textBox6.Text = x2.ToString();
            }
            else
            {
                textBox5.Text = "No answer";
                textBox6.Text = "No answer";
            }
            
            dis = Math.Round(dis, 5);
            textBox4.Text = dis.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
