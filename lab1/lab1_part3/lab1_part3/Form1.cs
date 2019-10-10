using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This application shows you if the number is odd or even.");

            button1.BackColor = Color.Maroon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                if (val1 % 2 == 0)
                {
                    label1.Text = "Even!";
                }
                else 
                {
                    label1.Text = "Odd!";
                }
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to exit?", "WE WILL MISS YOU!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
