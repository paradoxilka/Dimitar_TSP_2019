using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int month = int.Parse(dateTimePicker1.Value.ToString("MM"));
            int day = int.Parse(dateTimePicker1.Value.ToString("dd"));
            string sign = "";

            if (month == 12)
            {

                if (day < 22)
                    sign = "Sagittarius";
                else
                    sign = "capricorn";
            }
            else if (month == 1)
            {
                if (day < 20)
                    sign = "Capricorn";
                else
                    sign = "aquarius";
            }

            else if (month == 2)
            {
                if (day < 19)
                    sign = "Aquarius";
                else
                    sign = "pisces";
            }

            else if (month == 3)
            {
                if (day < 21)
                    sign = "Pisces";
                else
                    sign = "aries";
            }
            else if (month == 4)
            {
                if (day < 20)
                    sign = "Aries";
                else
                    sign = "taurus";
            }

            else if (month == 5)
            {
                if (day < 21)
                    sign = "Taurus";
                else
                    sign = "gemini";
            }

            else if (month == 6)
            {
                if (day < 21)
                    sign = "Gemini";
                else
                    sign = "cancer";
            }

            else if (month == 7)
            {
                if (day < 23)
                    sign = "Cancer";
                else
                    sign = "leo";
            }

            else if (month == 8)
            {
                if (day < 23)
                    sign = "Leo";
                else
                    sign = "virgo";
            }

            else if (month == 9)
            {
                if (day < 23)
                    sign = "Virgo";
                else
                    sign = "libra";
            }

            else if (month == 10)
            {
                if (day < 23)
                    sign = "Libra";
                else
                    sign = "scorpio";
            }

            else if (month == 11)
            {
                if (day < 22)
                    sign = "scorpio";
                else
                    sign = "sagittarius";
            }

            listBox1.Items.Add("Zodiac sign: " + sign);
        }
    }
}
