using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_part3
{
    public partial class Form1 : Form
    {
        int convert_from = 0, convert_to = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Convert from
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem) 
            {
                case "Feet":
                    convert_from = 0;
                    break;
                case "Yards":
                    convert_from = 1;
                    break;
                case "Inches":
                    convert_from = 2;
                    break;
                case "Miles":
                    convert_from = 3;
                    break;
            }
        }

        //Convert to
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Feet":
                    convert_to = 0;
                    break;
                case "Yards":
                    convert_to = 1;
                    break;
                case "Inches":
                    convert_to = 2;
                    break;
                case "Miles":
                    convert_to = 3;
                    break;
            }
        }

        //Close
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Refresh
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        //Calculate
        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            double[][] ref_array = new double[4][];
            ref_array[0] = new double[] { 1,        0.333,  12,     0.0001893 };    //feet
            ref_array[1] = new double[] { 3,        1,      36,     0.0005682 };    //yards
            ref_array[2] = new double[] { 0.083,    0.0277, 1,      0.0001579 };    //inches
            ref_array[3] = new double[] { 5280,     1760,   63360,  1 };            //miles

            try
            {
                result = (Double.Parse(textBox1.Text) * ref_array[convert_from][convert_to]);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в поле \"Convert:\"");
                textBox1.Clear();
            }

            textBox2.Text = result.ToString();
        }
    }
}
