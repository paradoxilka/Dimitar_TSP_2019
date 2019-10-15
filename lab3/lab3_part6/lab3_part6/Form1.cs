using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_part6
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int generated_numb;

        public Form1()
        {
            InitializeComponent();
            generated_numb = rand.Next(99) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input_numb = 0;
            try
            {
                input_numb = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни в полетата");
                textBox1.Clear();
            }
            
            if (generated_numb > input_numb)
            {
                MessageBox.Show("The inputed number is too low");
            }else if (generated_numb < input_numb)
            {
                MessageBox.Show("The inputed number is too heigh");
            }else 
            {
                MessageBox.Show("Yup, thats the one! Congrats!");
            }

        }
    }
}
