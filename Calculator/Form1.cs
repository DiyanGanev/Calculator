﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Core core = new Core();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please enter a number");
            }
            else
            {
                core.Current = Convert.ToDouble(textBox1.Text);
                core.Add();
                label1.Text = Convert.ToString(core.Current + " +");
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please enter a number");
            }
            else
            {
                core.Current = Convert.ToDouble(textBox1.Text);
                core.substract();
                label1.Text = Convert.ToString(core.Current + " -");
                textBox1.Clear();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please enter a number");
            }
            else
            {
                core.Current = Convert.ToDouble(textBox1.Text);
                core.multiply();
                label1.Text = Convert.ToString(core.Current + " *");
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please enter a number");
            }
            else
            {
                core.Current = Convert.ToDouble(textBox1.Text);
                core.divide();
                label1.Text = Convert.ToString(core.Current + " /");
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 )
            {
                MessageBox.Show("please enter a number");
            }
            else
            {
                core.Current = Convert.ToDouble(textBox1.Text);
                core.equals();
                textBox1.Text = Convert.ToString(core.Result);
                label2.Text = Convert.ToString(core.y);
                core.clearArray();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
