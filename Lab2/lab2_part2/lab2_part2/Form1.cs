using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_part2
{
    public partial class Form1 : Form
    {
        double temp_input;
        int input_sys=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem) 
            {
                case "Celsius":
                    input_sys = 0;
                    label3.Text = "Celsius to Celsius:";
                    break;
                case "Fahrenheit":
                    input_sys = 1;
                    label3.Text = "Fahrenheit to Celsius:";
                    break;
                case "Kelvin":
                    input_sys = 2;
                    label3.Text = "Kelvin to Celsius:";
                    break;
                case "Rankine":
                    input_sys = 3;
                    label3.Text = "Rankine to Celsius:";
                    break;
                case "Réaumur":
                    input_sys = 4;
                    label3.Text = "Réaumur to Celsius:";
                    break;
            }
            calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                temp_input = Double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в поле \"Convert:\"");
                textBox1.Clear();
            }
            calculate();
        }

        private void calculate() 
        {
            switch (input_sys) 
            {
                case 0:
                    textBox2.Text = temp_input.ToString();
                    break;
                case 1:
                    textBox2.Text = (temp_input*1.8+32).ToString();
                    break;
                case 2:
                    textBox2.Text = (temp_input-273.15).ToString();
                    break;
                case 3:
                    textBox2.Text = ((temp_input+273.15)*9/5).ToString();
                    break;
                case 4:
                    textBox2.Text = (temp_input*0.8).ToString();
                    break;

            }
        }
    }
}
