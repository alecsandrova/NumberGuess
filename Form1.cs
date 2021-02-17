using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuess17feb
{
    public partial class Form1 : Form
    {
        
        int num;
        int min;
        int max;
       

        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            num = random.Next(100);
            button4.Visible = false;
            button5.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Random number generator";



        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                int value = int.Parse(textBox1.Text);

                if ( value == Convert.ToInt32(num))
                {
                    label1.Text = "You guessed the number! ";
                }


                if (value < Convert.ToInt32(num))
                {
                    label1.Text = "Greater!";
                }


                else if (value > Convert.ToInt32(num))
                {
                    label1.Text = "Less!";
                }
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Guess the new number!";
                Random random = new Random();
                num = random.Next(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = "Enter the min:";
            button1.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                 min = int.Parse(textBox1.Text);
                textBox1.Clear();
                label1.Text = "Enter the max:";
                button4.Visible = false;
                button5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                max = int.Parse(textBox1.Text);
                textBox1.Clear();
                button5.Visible = false;
                button1.Visible = true;
                label1.Text = "Guess the number!";
                Random random = new Random();
                num = random.Next(min, max);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
