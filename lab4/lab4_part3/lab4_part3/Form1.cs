using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text)) 
            {
                double rotate = double.Parse(textBox1.Text);
                MessageBox.Show("Trigonometry functions: \ncos " + rotate.ToString() + " = " + Math.Round(Math.Cos(rotate), 3) + "\nsin " + rotate.ToString() + " = " + Math.Round(Math.Sin(rotate), 3) + "\ntg " + rotate.ToString() + " = " + Math.Round(Math.Tan(rotate), 3));
                textBox1.Text = "";
            }
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                double radius = double.Parse(textBox2.Text);
                MessageBox.Show("S and P of the circle: \nS=" + Math.Round(Math.PI * Math.Pow(radius, 2), 2) + "\nP=" + Math.Round(Math.PI * radius * 2, 2));
                textBox2.Text = "";
            }
        }
    }
}
