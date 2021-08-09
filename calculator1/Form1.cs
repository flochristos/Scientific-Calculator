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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
        double store = 0;
        double equals = 0;

        /*
 * ////////////////////////////////////////////////////////////////////////////
 * ////////////////////////// buttons for the calculator //////////////////////
 * ////////////////////////////////////////////////////////////////////////////
 */
        private void btn1_Click(object sender, EventArgs e)
        {

            txtDisplay.Text += btn1.Text;
         

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn4.Text;
          
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn5.Text;
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn6.Text;
           
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn7.Text;
           
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn8.Text;
           
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn9.Text;
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn0.Text;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }
        bool plusButtonClicked = true;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool power = false;
        private void btnMinus_Click(object sender, EventArgs e)
        {
            
            store = store + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            power = false;
        }

        public void btnPlus_Click(object sender, EventArgs e)
        {
            store = store + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            power = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            store = store + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
            power = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            store = store + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
            power = false;
        }
/*
 * ////////////////////////////////////////////////////////////////////////////
 * code for the equal button.
 * ////////////////////////////////////////////////////////////////////////////
 */
        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            if (plusButtonClicked == true)
            {
                
                equals = store + double.Parse(txtDisplay.Text);
                txtDisplay.Text = equals.ToString();
                label1.Text = store.ToString() + " + " + txtDisplay.Text + " = " + equals.ToString();
                store = 0;

            }
            else if (minusButtonClicked == true)
            {  
                label1.Text = store.ToString() + " - " + txtDisplay.Text + " = " + equals.ToString();
                equals = store - double.Parse(txtDisplay.Text);
                txtDisplay.Text = equals.ToString();
                store = 0;
            }
            else if (divideButtonClicked == true)
            {
                label1.Text = store.ToString() + " / " + txtDisplay.Text + " = " + equals.ToString();
                equals = store / double.Parse(txtDisplay.Text);
                txtDisplay.Text = equals.ToString();
                store = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                label1.Text = store.ToString() + " * " + txtDisplay.Text + " = " + equals.ToString();
                equals = store*double.Parse(txtDisplay.Text);
                txtDisplay.Text = equals.ToString();
                store = 0;
            }
            else if (power == true)
            {

                label1.Text = store.ToString() + " ^ " + txtDisplay.Text + " = " + equals.ToString();
                double answer = Math.Pow(store, double.Parse(txtDisplay.Text));
                txtDisplay.Text = answer.ToString();
                store = 0;
            }
            
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                double root = Math.Sqrt(double.Parse(txtDisplay.Text));
                txtDisplay.Text = root.ToString();
            }
        }
        // cube root code.
        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                double sqr3 = Math.Pow(double.Parse(txtDisplay.Text), 0.333333333333333333333333333333333333333);
                txtDisplay.Text = sqr3.ToString();
            }
        }
        // raised to power 2 code
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                txtDisplay.Text = Math.Pow(double.Parse(txtDisplay.Text), 2).ToString();
            }
        }
        // inverse code i.e. 1/x
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                double one = 1.0;
                txtDisplay.Text = (one / (double.Parse(txtDisplay.Text))).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        //raised to power buttoon
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                store = store + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
                power = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            { }
            else
            {
                txtDisplay.Text = (double.Parse(txtDisplay.Text) / 100).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
         if (txtDisplay.Text == "")
            {

            }
            else
            
            {
                double input = double.Parse(txtDisplay.Text);
                double answer = 1;
                for (double i = 1; i < input; i++)
                {
                    answer *= i;
                    txtDisplay.Text = answer.ToString();
                    
                }
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you really wanna exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scientificCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really wanna exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



    }
}
