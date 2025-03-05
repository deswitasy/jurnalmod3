using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal_modul3_103022300004
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int X;
        int Y;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            X = 2;
            label1.Text = X.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X = 1;
            label1.Text = X.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            X = 3;
            label1.Text = X.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            X = 4;
            label1.Text = X.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            X = 5;
            label1.Text = X.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            X = 6;
            label1.Text = X.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            X = 7;
            label1.Text = X.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            X = 8;
            label1.Text = X.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            X = 9;
            label1.Text = X.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            X = 0;
            label1.Text = X.ToString();
        }

        private void buttontmbh_Click(object sender, EventArgs e)
        {
            Y = X;
            X = 0;
            label1.Text = "";
        }

        private void buttonsm_Click(object sender, EventArgs e)
        {
            int hasil = X + Y;
            label1.Text = hasil.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
