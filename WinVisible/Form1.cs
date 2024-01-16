using LibraryTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVisible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!label1.Visible)
            {
                label1.Visible = true;  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Visible)
            {
                label1.Visible = false;
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //if (label1.Visible)
            //{
            //    label1.Visible = false;
            //}
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
           
            //if (!label1.Visible)
            //{
            //    label1.Visible = true;
            //}
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("you are over me");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestClass testClass = new TestClass();
            
            label2.Text = testClass.Show(textBox1.Text);

        }
    }
}
