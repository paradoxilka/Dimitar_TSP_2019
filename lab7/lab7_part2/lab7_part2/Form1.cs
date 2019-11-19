using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace lab7_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            JulianCalendar myCal = new JulianCalendar();
            textBox1.Text = (myCal.GetDayOfYear(dateTimePicker1.Value)).ToString();
        }
    }
}
