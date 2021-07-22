using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // labelresult.Text = (textBox1.Text * textBox2.Text);
            double text1 = double.Parse(textBox1.Text);
            double text2 = double.Parse(textBox2.Text);


            labelresult.Text = (text1 + text2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double text1 = double.Parse(textBox1.Text);
            double text2 = double.Parse(textBox2.Text);


            labelresult.Text = (text1 - text2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double text1 = double.Parse(textBox1.Text);
            double text2 = double.Parse(textBox2.Text);


            labelresult.Text = (text1 * text2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double text1 = double.Parse(textBox1.Text);
            double text2 = double.Parse(textBox2.Text);


            labelresult.Text = (text1 / text2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
