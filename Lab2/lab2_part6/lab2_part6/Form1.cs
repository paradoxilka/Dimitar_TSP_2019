using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_part6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            calc();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            calc();
        }

        private void calc() 
        {
            label2.Text = hScrollBar1.Value.ToString();
            label3.Text = vScrollBar1.Value.ToString();
            label6.Text = (hScrollBar1.Value * vScrollBar1.Value).ToString();
        }

    }
}
