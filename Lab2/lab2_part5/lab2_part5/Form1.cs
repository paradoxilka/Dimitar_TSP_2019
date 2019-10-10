using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_part5
{
    public partial class Form1 : Form
    {
        double sum_all = 0;
        int client_counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private double calculate() 
        {
            double electricity = 0;

            try
            {
                electricity = (Double.Parse(textBox2.Text) - Double.Parse(textBox1.Text));
            }
            catch
            {
                if (!(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)))
                {
                    MessageBox.Show("Въведете коректни данни в полетата");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }

            label7.Text = electricity.ToString() + "KWh";

            if (radioButton1.Checked == true)
            {
                electricity *= 0.34;
            }
            else if (radioButton2.Checked == true)
            {
                electricity *= 0.44;
            }
            else if (radioButton3.Checked == true)
            {
                electricity *= 0.54;
            }

            label8.Text = electricity.ToString() + "BGN";
            return electricity;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sum_all += calculate();
            client_counter++;
            label2.Text = client_counter.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sum_all += calculate();
            MessageBox.Show("The electricity consumed by all the " + client_counter.ToString() + " clients costs: " + sum_all.ToString() + "BGN\n Every person owes roughly " + Math.Round((sum_all / client_counter), 0).ToString() + "BGN");
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pretty useless app made by the retard also known as Dimitar");
        }
    }
}
