using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Списки
{
    public partial class Form1 : Form
    {
        NewList<string> ListString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() != 0)
            {
                ListString.AddLast(textBox1.Text);
            }
            label4.Text = ListString.ToString();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() != 0)
            {
                ListString.AddFirst(textBox1.Text);
            }
            label4.Text = ListString.ToString();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() != 0)
            {
                ListString.Add(textBox1.Text, Convert.ToInt32(textBox3.Text) - 1);
            }
            label4.Text = ListString.ToString();
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListString.DeleteLast();
            label4.Text = ListString.ToString();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListString.DeleteFirst();
            label4.Text = ListString.ToString();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListString.DeletePos(Convert.ToInt32(textBox3.Text) - 1);
            label4.Text = ListString.ToString();
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(ListString.Search(textBox2.Text)) + " " + "позиция";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(ListString.Search(Convert.ToInt32(textBox2.Text) - 1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListString = new NewList<string>();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ListString = new NewList<string>();
        }
    }
}
