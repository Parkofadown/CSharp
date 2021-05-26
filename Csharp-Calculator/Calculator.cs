using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1CalculatorProjectRichardBoyd
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void OutPutBox_TextChanged(object sender, EventArgs e)
        {

        }
        // 0 BUTTON
        private void Zero_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "0" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "0";
            }
            else
            {
                OutPutBox.Text += "0";
            }

        }
        // 1 BUTTON
        private void One_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "1" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "1";
            }
            else
            {
                OutPutBox.Text += "1";
            }

        }
        // 2 BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "2" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "2";
            }
            else
            {
                OutPutBox.Text += "2";
            }

        }
        // 3 BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "3" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "3";
            }
            else
            {
                OutPutBox.Text += "3";
            }

        }
        // 4 BUTTON
        private void Four_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "4" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "4";
            }
            else
            {
                OutPutBox.Text += "4";
            }

        }
        // 5 BUTTON
        private void button7_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "5" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "5";
            }
            else
            {
                OutPutBox.Text += "5";
            }

        }
        // 6 BUTTON
        private void button8_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "6" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "6";
            }
            else
            {
                OutPutBox.Text += "6";
            }

        }
        // 7 BUTTON
        private void Seven_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "7" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "7";
            }
            else
            {
                OutPutBox.Text += "7";
            }

        }
        // 8 BUTTON
        private void Eight_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "8" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "8";
            }
            else
            {
                OutPutBox.Text += "8";
            }

        }
        // 9 BUTTON
        private void button11_Click(object sender, EventArgs e)
        {
            if (OutPutBox.Text == "9" && OutPutBox.Text != null)
            {
                OutPutBox.Text = "9";
            }
            else
            {
                OutPutBox.Text += "9";
            }

        }
        // C BUTTON CLICKED
        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutPutBox.Clear();
        }
        // DECIMAL BUTTON CLICKLED
        private void Decimal_Click(object sender, EventArgs e)
        {
            OutPutBox.Text += ".";
        }
        // PLUS BUTTON CLICKED
        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(OutPutBox.Text);
                OutPutBox.Clear();
                Operation = "+";
            }
            catch (FormatException)
            {

            }
            
        }
        // MINUS BUTTON CLICKED
        private void Minus_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(OutPutBox.Text);
                OutPutBox.Clear();
                Operation = "-";
            } 
            catch (FormatException)
            {
               
            } 
        
        }
        // MULTIPLY BUTTON CLICKED
        private void Multiply_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(OutPutBox.Text);
                OutPutBox.Clear();
                Operation = "*";
            } 
            catch (FormatException)
            {

            }
               
        }
        // DIVIDE BUTTON CLICKED
        private void Divide_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(OutPutBox.Text);
                OutPutBox.Clear();
                Operation = "/";
            }
            catch (FormatException)
            {

            }
           
        }

        // EQUALS BUTTON CLICKED
        private void Equals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;


            SecondNumber = Convert.ToDouble(OutPutBox.Text);


            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                OutPutBox.Text = Convert.ToString(Result);
                FirstNumber = Result;

            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                OutPutBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                OutPutBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    OutPutBox.Text = "Error div by 0";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    OutPutBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }

            }

        }

        private void OutPutBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
