using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quasar_Shopitem_Adder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { 
                checkBox2.Checked = false;
            }
            else
            {

            }


                
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox2.Text);
            var name = textBox1.Text;
            var label = textBox3.Text;
            var price = Convert.ToInt32(textBox4.Text);
            var amount = Convert.ToInt32(textBox5.Text);
            var type = "none";
            var slot = Convert.ToInt32(textBox6.Text);

            if (checkBox1.Checked == true)
                type = "\'weapon\'";
            else if (checkBox2.Checked == true)
                type = "\'item\'";
            else
                type = "\'none\'";


            richTextBox1.Multiline = true;
            richTextBox1.Text = $"{richTextBox1.Text}\r\n" +
                                $"[\'{num}\'] = " + "{\r\n" +
                                $"      name = \'{name}\',\r\n" +
                                $"      label  = \'{label}\',\r\n" +
                                $"      price = {price},\r\n" +
                                $"      amount = {amount},\r\n" +
                                $"      info = {{}},\r\n" +
                                $"      type = \'{type}\',\r\n" +
                                $"      slot = {slot},\r\n" +
                                "},";
            num = num + 1;
            textBox2.Text = Convert.ToString(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox1.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
