using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_part4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age_years = 0, age_months = 0;
            try
            {
                DateTime dateOfBirth = new DateTime(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                age_years = DateTime.Now.Year - dateOfBirth.Year;
                age_months = DateTime.Now.Month - dateOfBirth.Month;
                MessageBox.Show("Your exact age is: " + age_years.ToString() + " years and " + age_months.ToString() + " months!"); 
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в полетата");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
