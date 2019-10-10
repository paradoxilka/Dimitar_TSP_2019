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
    public partial class Binomial : Form
    {
        public Binomial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, result = 0;

            try
            {
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в полетата");
                textBox1.Clear();
                textBox2.Clear();
            }

            if (radioButton1.Checked)
            {
                result = (Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2));
            }
            else if (radioButton2.Checked)
            {
                result = (Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2));
            }
            else if (radioButton3.Checked)
            {
                result = (Math.Pow(a, 2) - Math.Pow(b, 2));
            }
            else if (radioButton4.Checked)
            {
                result = (Math.Pow(a, 3) + Math.Pow(b, 3) + 3 * a * b * (a + b));
            }
            else if (radioButton5.Checked)
            {
                result = (Math.Pow(a, 3) - Math.Pow(b, 3) - 3 * a * b * (a - b));
            }
            else if (radioButton6.Checked)
            {
                result = ((a + b) * (Math.Pow(a, 2) - a * b + Math.Pow(b, 2)));
            }
            else if (radioButton7.Checked)
            {
                result = ((a - b) * (Math.Pow(a, 2) + a * b + Math.Pow(b, 2)));
            }

            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
