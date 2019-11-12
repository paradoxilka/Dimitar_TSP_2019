using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_part2
{
    public partial class Form1 : Form
    {
        bool addFlag = false, subFlag = false, mulFlag = false, devFlag = false;
        int addL, addR, subL, subR, mulL, mulR, devR, devL, i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            i = 40 * 10;

            time.Text = i/10 + "sec left";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 40 * 10;
            Random randomizer = new Random();

            addL = randomizer.Next(51);
            addR = randomizer.Next(51);
            subL = randomizer.Next(51);
            subR = randomizer.Next(51);
            mulL = randomizer.Next(51);
            mulR = randomizer.Next(51);
            devR = randomizer.Next(51)+1;
            devL = randomizer.Next(11) * devR;

            addLeft.Text = addL.ToString();
            addRight.Text = addR.ToString();
            subLeft.Text = subL.ToString();
            subRight.Text = subR.ToString();
            mulLeft.Text = mulL.ToString();
            mulRight.Text = mulR.ToString();
            devLeft.Text = devL.ToString();
            devRight.Text = devR.ToString();

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = --i/10 + "sec left";
            if ((addL + addR) == numericUpDown1.Value)
            {
                addFlag = true;
            }
            if ((subL - subR) == numericUpDown2.Value)
            {
                subFlag = true;
            }
            if ((mulL * mulR) == numericUpDown3.Value)
            {
                mulFlag = true;
            }
            if ((devL / devR) == numericUpDown4.Value)
            {
                devFlag = true;
            }
            if (addFlag && subFlag && mulFlag && devFlag) 
            {
                timer1.Stop();

                MessageBox.Show("You got all the answers right \nand finished with " + i/10 + " seconds left", "Congrats!");
            }
            if (i <= 0) 
            {
                timer1.Stop();
                MessageBox.Show("Sorry", "You didn't finish at time");
                i = 30 * 10;
            }
        }
    }
}
