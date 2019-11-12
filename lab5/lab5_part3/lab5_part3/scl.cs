using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace lab5_part3
{
    public partial class scl : Form
    {
        public scl()
        {
            InitializeComponent();
        }

        private void scl_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]\d{0,9}(\.\d{1,1})?%?$");
            Match txt1 = r.Match(textBox1.Text);
            Match txt2 = r.Match(textBox2.Text);
            Match txt3 = r.Match(textBox3.Text);

            if (txt1.Success && txt3.Success && txt2.Success)
            {
                MessageBox.Show("Въведохте правилни данни!");
            }
            else
            {
                MessageBox.Show("Моля въведете правилни данни!");
            }

            double a, b, c, d;

            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            c = Double.Parse(textBox3.Text);
            d = ((a + b) - c);

            textBox4.Text = d.ToString();
        }
    }
}
