using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_part6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pizza = "";
            double price = 0;
            try
            {
                if (radioButton1.Checked)
                {
                    price += 9.25;
                    pizza += "You ordered a small";
                }
                else if (radioButton2.Checked)
                {
                    price += 11.50;
                    pizza += "You ordered a medium";
                }
                else if (radioButton3.Checked)
                {
                    price += 13.75;
                    pizza += "You ordered a large";
                }
                if (radioButton4.Checked)
                {
                    pizza += ", thin pizza";
                }
                else if (radioButton5.Checked)
                {
                    pizza += ", thick pizza";
                }
                else pizza += " pizza";
                if (checkBox1.Checked)
                {
                    price += 1.50;
                    pizza += " with extra cheese";
                }
                else pizza += " with";
            }

            catch { }


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    pizza += ", " + checkedListBox1.Items[i].ToString();
                    price += 1;
                }

            }
            pizza += ". \r\nYour total is " + price + "$";
            richTextBox1.Text = pizza;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("addons.txt");
            foreach (string str in lines)
            {
                checkedListBox1.Items.Add(str);
            }
        }
    }
}
