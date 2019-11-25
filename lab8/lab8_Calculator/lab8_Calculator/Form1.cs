using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace lab8_Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        double left = 0;
        double right = 0;
        int function = 0;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Focus();
        }

        public static double ConvertToDouble(string Value)
        {
            double OutVal = 0;
            double.TryParse(Value, out OutVal);

            if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
            {
                return 0;
            }
            return OutVal;
        }

        public string getLast(string textbox) 
        {
            string[] tokens = textbox.Split(' ');
            return tokens[tokens.Length - 1];
        }

        public void removeLast()
        {
            string temp = richTextBox1.Text;
            string last = getLast(richTextBox1.Text);
            temp = temp.Substring(0, temp.Length - last.Length);
            richTextBox1.Text = temp;
        }

        public void outputEqu() 
        {
            richTextBox1.Text = richTextBox1.Text + " \n= " + result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = Math.Pow(ConvertToDouble(getLast(richTextBox1.Text)), 2);
            richTextBox1.Text = richTextBox1.Text + " ^ 2";
            outputEqu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            left = ConvertToDouble(getLast(richTextBox1.Text));
            richTextBox1.Text = richTextBox1.Text + " ^ ";
            function = 1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (function != 0)
            {
                string[] tokens = richTextBox1.Text.Split(' ');
                right = ConvertToDouble(tokens[tokens.Length - 1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = Math.Sin(ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " Sin("+richTextBox1.Text+")";
            outputEqu();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (function == 1)
            {
                result = Math.Pow(left, right);
            }
            if (function == 2)
            {
                result = left - right;
            }
            if (function == 3)
            {
                result = left + right;
            }
            if (function == 4)
            {
                result = left * right;
            }
            if (function == 5)
            {
                result = left / right;
            }
            outputEqu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = Math.Cos(ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " Cos(" + richTextBox1.Text + ")";
            outputEqu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = Math.Tan(ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " Tan(" + getLast(richTextBox1.Text) + ")";
            outputEqu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result = Math.Pow(ConvertToDouble(getLast(richTextBox1.Text)), 3);
            richTextBox1.Text = richTextBox1.Text + " ^ 3";
            outputEqu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = (1 / ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " 1 / " + getLast(richTextBox1.Text);
            outputEqu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result = Math.Pow(10, ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " 10 ^ " + getLast(richTextBox1.Text);
            outputEqu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result = Math.Exp(ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " Exp(" + getLast(richTextBox1.Text) + ")";
            outputEqu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result = Math.Abs(ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " Mod(" + getLast(richTextBox1.Text) + ")";
            outputEqu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            removeLast();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            temp = temp.Substring(0, temp.Length - 1);
            richTextBox1.Text = temp;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (Math.PI).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result = Math.Log(ConvertToDouble(getLast(richTextBox1.Text)));
            richTextBox1.Text = richTextBox1.Text + " Log(" + getLast(richTextBox1.Text) + ")";
            outputEqu();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            left = ConvertToDouble(getLast(richTextBox1.Text));
            richTextBox1.Text = richTextBox1.Text + " - ";
            function = 2;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            left = ConvertToDouble(getLast(richTextBox1.Text));
            richTextBox1.Text = richTextBox1.Text + " + ";
            function = 3;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            result = 0.01*ConvertToDouble(getLast(richTextBox1.Text));
            richTextBox1.Text = richTextBox1.Text + " % ";
            outputEqu();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            left = ConvertToDouble(getLast(richTextBox1.Text));
            richTextBox1.Text = richTextBox1.Text + " * ";
            function = 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            left = ConvertToDouble(getLast(richTextBox1.Text));
            richTextBox1.Text = richTextBox1.Text + " / ";
            function = 5;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

    }
}
