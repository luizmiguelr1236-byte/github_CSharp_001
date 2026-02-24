using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github_CSharp_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "  ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked) {
                    label1.Text = "+";
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox3.Text = Convert.ToString(a + b);
                }
                else if (radioButton2.Checked) {
                    label1.Text = "-";
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox3.Text = Convert.ToString(a - b); 
                }
                else if (radioButton3.Checked) {
                    label1.Text = "/";
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox3.Text = Convert.ToString(a / b);
                }
                else if (radioButton4.Checked) {
                    label1.Text = "*";
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox3.Text = Convert.ToString(a * b);
                }
                
            }
            catch (Exception ex) { MessageBox.Show("qualé irmão, só números."+ Environment.NewLine+" erro: " + ex); }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "*";
        }
    }
}
