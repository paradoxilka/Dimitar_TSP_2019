using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_part1
{
    public partial class Form1 : Form
    {
        struct Question
        {
            public string QuestionText;
            public string AnswerA;
            public string AnswerB;
            public string AnswerC;
            public string AnswerD;
            public int CorrectAnswer;
        }
        public Form1()
        {
            InitializeComponent();
            button2.Click += new EventHandler(Click1);
        }
        int correct = 0, i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Text = "Start";
        }

        private void Click1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label2.Visible = true;
            button2.Text = "Submit";

            Question[] array_of_questions = new Question[10];
            array_of_questions[0].QuestionText = "What color is snow?";
            array_of_questions[0].AnswerA = "Red";
            array_of_questions[0].AnswerB = "Yellow";
            array_of_questions[0].AnswerC = "White";
            array_of_questions[0].AnswerD = "Green";
            array_of_questions[0].CorrectAnswer = 2;

            array_of_questions[1].QuestionText = "What is the capital of Bulgaria?";
            array_of_questions[1].AnswerA = "Sofia";
            array_of_questions[1].AnswerB = "Paris";
            array_of_questions[1].AnswerC = "London";
            array_of_questions[1].AnswerD = "Varna";
            array_of_questions[1].CorrectAnswer = 0;

            array_of_questions[2].QuestionText = "What is 3*9?";
            array_of_questions[2].AnswerA = "12";
            array_of_questions[2].AnswerB = "62";
            array_of_questions[2].AnswerC = "37";
            array_of_questions[2].AnswerD = "27";
            array_of_questions[2].CorrectAnswer = 3;

            array_of_questions[3].QuestionText = "how do you spell BMW?";
            array_of_questions[3].AnswerA = "A-B-M";
            array_of_questions[3].AnswerB = "E-M-Y";
            array_of_questions[3].AnswerC = "B-M-W";
            array_of_questions[3].AnswerD = "I-M-C";
            array_of_questions[3].CorrectAnswer = 2;

            array_of_questions[4].QuestionText = "What is the powerhouse of the cell?";
            array_of_questions[4].AnswerA = "Mitochondria";
            array_of_questions[4].AnswerB = "Chromosome";
            array_of_questions[4].AnswerC = "Endoplasmic reticulum";
            array_of_questions[4].AnswerD = "Endomembrane";
            array_of_questions[4].CorrectAnswer = 0;

            array_of_questions[5].QuestionText = "Why did the chicken cross the road?";
            array_of_questions[5].AnswerA = "Bcz it was retarded";
            array_of_questions[5].AnswerB = "Pink";
            array_of_questions[5].AnswerC = "1000";
            array_of_questions[5].AnswerD = "To crack open a cold one with the boys";
            array_of_questions[5].CorrectAnswer = 3;

            array_of_questions[6].QuestionText = "What is the mass of the sun?";
            array_of_questions[6].AnswerA = "1.989 × 10^30 kg";
            array_of_questions[6].AnswerB = "1000 t.";
            array_of_questions[6].AnswerC = "enough";
            array_of_questions[6].AnswerD = "10gr";
            array_of_questions[6].CorrectAnswer = 0;

            array_of_questions[7].QuestionText = "if 56-10 is 40 then what is 23-10?";
            array_of_questions[7].AnswerA = "11";
            array_of_questions[7].AnswerB = "7";
            array_of_questions[7].AnswerC = "13";
            array_of_questions[7].AnswerD = "16";
            array_of_questions[7].CorrectAnswer = 1;

            array_of_questions[8].QuestionText = "Does the spider have puss-puss?";
            array_of_questions[8].AnswerA = "probably yes";
            array_of_questions[8].AnswerB = "maby";

            array_of_questions[8].AnswerC = "NOOOOO";
            array_of_questions[8].AnswerD = "IDK";
            array_of_questions[8].CorrectAnswer = 2;

            array_of_questions[9].QuestionText = "If you have 2 eggs and eat 1, how much does a cow weight?";
            array_of_questions[9].AnswerA = "100kg";
            array_of_questions[9].AnswerB = "WTF 1000kg OFC gg ez";
            array_of_questions[9].AnswerC = "500kg";
            array_of_questions[9].AnswerD = "200kg";
            array_of_questions[9].CorrectAnswer = 1;

            if (i < 11)
            {
                if (radioButton1.Checked && array_of_questions[i-1].CorrectAnswer == 0)
                    correct++;
                if (radioButton2.Checked && array_of_questions[i-1].CorrectAnswer == 1)
                    correct++;
                if (radioButton3.Checked && array_of_questions[i-1].CorrectAnswer == 2)
                    correct++;
                if (radioButton4.Checked && array_of_questions[i-1].CorrectAnswer == 3)
                    correct++;
                
                if (i < 10)
                {
                    label1.Text = array_of_questions[i].QuestionText;
                    radioButton1.Text = array_of_questions[i].AnswerA;
                    radioButton2.Text = array_of_questions[i].AnswerB;
                    radioButton3.Text = array_of_questions[i].AnswerC;
                    radioButton4.Text = array_of_questions[i].AnswerD;
                }

                i++;
            }
            if (i > 10)
            {
                if (correct == 10)
                {
                    pictureBox1.Visible = true;
                    MessageBox.Show("Congrats! you are accepted in Harvard with the whopping 10/10", "Harvard says:");
                }
                else
                {
                    MessageBox.Show("You are a retard and managed to get just " + correct + "/10");
                }
            } 
            label2.Text = correct + " right answers of 10";
        }
    }
}
