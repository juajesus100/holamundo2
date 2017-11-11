using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butsuma_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a + b;

            textBox3.Text = c.ToString();
        }

        private void butresta_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a - b;

            textBox3.Text = c.ToString();
        }

        private void butdivicion_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a / b;

            textBox3.Text = c.ToString();
        }

        private void butprom_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = (a + b)/2;

            textBox3.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a * b;

            textBox3.Text = c.ToString();
        }

        private void butmayor_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            if (num1 > num2)
            {

                textBox3.Text = num1.ToString();

            }
            else
            {
                textBox3.Text = num2.ToString();

            }
            

         
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butmenor_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            if (num1 < num2)
            {

                textBox3.Text = num1.ToString();

            }
            else
            {
                textBox3.Text = num2.ToString();

            }
            
        }

        private void butequiva_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int res = 0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            res = (num1 + num2) / 2;
            if (res >= 90)
            {
                textBox3.Text = "A";
            }
            else if (res >=80)
            {
                textBox3.Text = "B";
            }
            else if (res >= 70)
            {
                textBox3.Text = "C";
            }
            else
            {
                textBox3.Text = "E"; 
            }



        }
    }
}
