using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       bool btnLinearClicked =true;
      bool  btnQuadraticClicked=false;
    bool    btnSimultaneousClicked=false;

        
        private void btnLinear_Click(object sender, EventArgs e)
        {


            btnLinearClicked = true;
           


            if (btnLinearClicked == true)
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;

            }
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            
            btnQuadraticClicked = true;

            if (btnQuadraticClicked == true)
            {
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
            }

        }

        private void btnSimult_Click(object sender, EventArgs e)
        {
            btnSimultaneousClicked = true;

            if (btnSimultaneousClicked == true)
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(textBox1.Text);
            double secondNum = double.Parse(textBox2.Text);
            double answer = 0;


                answer = secondNum / -firstNum;
                label6.Text = "x = " + answer.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);
            double c = double.Parse(textBox5.Text);
            double sq = Math.Pow(b, 2);
            double root = Math.Sqrt(sq - 4*a*c);
            double x1 = (-b + root)/(2*a);
            double x2 = (-b - root) / (2 * a);

            label7.Text = "x1 = " + x1.ToString() + "\r\n"+"x2 = " + x2.ToString();
            x1 = 0;
            x2 = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs z)
        {
            double a = double.Parse(tb1.Text);
            double b = double.Parse(tb2.Text);
            double c = double.Parse(tb3.Text);
            double d = double.Parse(tb4.Text);
            double e = double.Parse(tb5.Text);
            double f = double.Parse(tb6.Text);
            double g, h, i, x, y;

            g = (a * d) - (c * b);
            h = (e * d) - (b * f);
            i = (a * f) - (e * c);

            x = h / g;
            y = i / g;

            label8.Text = "x = " + x + "\r\n" + "y = " + y;
        }


    }
}
