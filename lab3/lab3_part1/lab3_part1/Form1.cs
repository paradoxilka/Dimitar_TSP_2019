using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Power frm = new Power();
            frm.Show();
        }

        private void factoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binomial frm = new Binomial();
            frm.Show();
        }

        private void squareEquasionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadratic frm = new Quadratic();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
