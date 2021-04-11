using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
            focusLabel.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if((result.Text == "0")||(operation_Pressed))
            {
                result.Clear();
            }

            operation_Pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;

            focusLabel.Focus();
            
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(value != 0)
            {
                button19.PerformClick();
                operation_Pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_Pressed = true;
                equation.Text = value + " " + operation;
            }
            focusLabel.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    if(value > Double.Parse(result.Text))
                    {
                        value = (float)value;
                    }
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "x":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
            operation = "";
            focusLabel.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "+":
                    addButton.PerformClick();
                    break;
                case "-":
                    subtractButton.PerformClick();
                    break;
                case "/":
                    divideButton.PerformClick();
                    break;
                case "*":
                    multiplyButton.PerformClick();
                    break;
                case "=":
                    button19.PerformClick();
                    break;
                case "\r":
                    button19.PerformClick();
                    break;
                default:
                    break;
            } //switch end


        }

        private void percent_Click(object sender, EventArgs e)
        {
            value = Double.Parse(result.Text);
            result.Text = (value / 100.0).ToString();
            operation_Pressed = true;
            button19.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void square_click(object sender, EventArgs e)
        {
            value = Double.Parse(result.Text);
            result.Text = (value * value).ToString();
            operation_Pressed = true;
            button19.PerformClick();
        }
    }
}
