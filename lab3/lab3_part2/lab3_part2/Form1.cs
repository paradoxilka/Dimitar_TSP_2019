using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc() 
        {
            double doo = 0, dzpo = 0, healthcare = 0, salary = 0;
            
            try
            {
                salary = Double.Parse(textBox1.Text);
            }
            catch
            {
                if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
                {
                    MessageBox.Show("Въведете коректни данни в поле \"Salary:\"");
                    textBox1.Clear();
                }
            }

            if (radioButton1.Checked)
            {
                doo = 0.089 * salary;
                dzpo = 0;
                healthcare = 0.032 * salary;
            }
            else if (radioButton2.Checked)
            {
                doo = 0.067 * salary;
                dzpo = 0.022 * salary;
                healthcare = 0.032 * salary;
            }

            label7.Text = doo.ToString();
            label8.Text = dzpo.ToString();
            label9.Text = healthcare.ToString();
            label10.Text = (doo + dzpo + healthcare).ToString();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }
    }
}
