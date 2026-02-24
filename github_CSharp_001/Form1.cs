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
            label1.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked) {
                    label1.Text = "+";
                    double a, b;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    textBox3.Text = Convert.ToString(a + b);
                }
                else if (radioButton2.Checked) {
                    label1.Text = "-";
                    double a, b;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    textBox3.Text = Convert.ToString(a - b); 
                }
                else if (radioButton3.Checked) {
                    label1.Text = "/";
                    double a, b;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    textBox3.Text = Convert.ToString(a / b);
                }
                else if (radioButton4.Checked) {
                    label1.Text = "*";
                    double a, b;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    textBox3.Text = Convert.ToString(a * b);
                }
                else if (radioButton5.Checked)
                {
                    label1.Text = "Exp";
                    double a, b;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    textBox3.Text = Convert.ToString(Math.Pow(a,b));
                }



                else if (radioButton6.Checked)
                {
                    label1.Text = "Raiz";
                    double a, b;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    textBox3.Text = Convert.ToString(a * b);
                }
            }
            catch (Exception ex) { MessageBox.Show("qualé irmão, só números e sem espaços"+ Environment.NewLine+" erro: " + ex); }



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
            label1.Text = "/";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Exp";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Raiz";
        }
    }
}
