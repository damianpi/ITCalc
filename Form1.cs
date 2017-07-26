using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dec = Int32.Parse(textBox1.Text); //decimal
                textBox2.Text = Convert.ToString(dec, 2);
                textBox3.Text = Convert.ToString(dec, 8);
                textBox4.Text = Convert.ToString(dec, 16);
            }
            catch (OverflowException oe)
            {
                textBox1.Text = "The given number is too big";
            }
            catch (Exception err) {
                textBox1.Text = "Wrong number format";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int dec = Convert.ToInt32((textBox2.Text), 2); //decimal
                textBox1.Text = Convert.ToString(dec);
                textBox3.Text = Convert.ToString(dec, 8);
                textBox4.Text = Convert.ToString(dec, 16);
            }
            catch (OverflowException oe)
            {
                textBox2.Text = "The given number is too big";
            }
            catch (Exception err)
            {
                textBox2.Text = "Wrong number format";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int dec = Convert.ToInt32((textBox3.Text), 8); //decimal
                textBox1.Text = Convert.ToString(dec);
                textBox2.Text = Convert.ToString(dec, 2);
                textBox4.Text = Convert.ToString(dec, 16);
            }
            catch (OverflowException oe)
            {
                textBox3.Text = "The given number is too big";
            }
            catch (Exception err)
            {
                textBox3.Text = "Wrong number format";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int dec = Convert.ToInt32((textBox4.Text), 16); //decimal
                textBox1.Text = Convert.ToString(dec);
                textBox2.Text = Convert.ToString(dec, 2);
                textBox3.Text = Convert.ToString(dec, 8);
            }
            catch (OverflowException oe)
            {
                textBox4.Text = "The given number is too big";
            }
            catch (Exception err)
            {
                textBox4.Text = "Wrong number format";
            }
        }
    }//end of class
}//end of namespace
