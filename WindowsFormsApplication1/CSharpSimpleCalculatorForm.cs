using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class calculator : Form
    {
        double num1, result;
        char operation;
        public calculator()
        {
            InitializeComponent();
            operation = ' ';
            result = 0;
            num1 = 0;
            label2.Visible = false;

        }

        public void setNumber(string number)
        {
            bool dots = true;
            if (number == ".")
            {
                if (lcd_calc.Text.Contains("."))
                {
                    dots = false;
                }
            }
            if (dots)
            {
                if (lcd_calc.Text.Length == 1)
                {
                    if (lcd_calc.Text == "0")
                        lcd_calc.Text = number;
                    else if (number == ".")
                        lcd_calc.Text = "0"+lcd_calc.Text + number;
                    else
                        lcd_calc.Text = lcd_calc.Text + number;

                }
                else
                    lcd_calc.Text = lcd_calc.Text + number;
            }
            label2.Visible = false;
        }

        public void setOperation(char op)
        {
            if (lcd_calc.Text.ToString().Length == 1)
            {
                if (lcd_calc.Text == "+" || lcd_calc.Text == "-")
                {
                    lcd_calc.Text = lcd_calc.Text + "0";

                }
                if(lcd_calc.Text == ".")
                    lcd_calc.Text = "0"+lcd_calc.Text + "0";
               

            }

            if (operation == ' ')
            {
                
                if (lcd_calc.Text.ToString() != "")
                {
                    operation = op;
                    num1 = Convert.ToDouble(lcd_calc.Text);
                    if (op == '!')
                    {
                        calculateData();
                    }
                    else
                    {
                        
                        lcd_calc.Text = "";
                        label2.Visible = true;
                        label2.Text = "" + op;
                    }

                }
                else
                {

                    if (op == '!')
                    {
                        calculateData();
                    }
                    else if (op == '+' || op == '-')
                        setNumber("" + op);

                }

            }

        }

        public void calculateData()
        {

            if (lcd_calc.Text != "") {
                if (operation != ' ')
                {

                    if (operation == '+')
                    {
                        result = (num1 + (Convert.ToDouble(lcd_calc.Text)));
                    }
                    else if (operation == '-')
                    {
                        result = (num1 - (Convert.ToDouble(lcd_calc.Text)));
                    }
                    else if (operation == '*')
                    {
                        result = (num1 * (Convert.ToDouble(lcd_calc.Text)));
                    }
                    else if (operation == '/')
                    {
                        result = (num1 / (Convert.ToDouble(lcd_calc.Text)));
                    }
                    else if (operation == '%')
                    {
                        result = (num1 % (Convert.ToDouble(lcd_calc.Text)));
                    }
                    else if(operation == '^')
                    {
                        result = 1;
                        for(int i=0; i< (Convert.ToDouble(lcd_calc.Text)); i++)
                        {
                            result *= num1;
                        }
                    }
                    else if (operation == '!')
                    {
                        result = 1;
                        for (int i = 1; i < (num1+1); i++)
                            result *= i;

                    }
                    else
                        result = 0;
                    lcd_calc.Text = "" + result;
                    operation = ' ';
                    label2.Visible = true;
                    label2.Text = "=";

                }
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            setNumber("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculateData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setOperation('-');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setOperation('+');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setOperation('*');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setOperation('/');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                lcd_calc.Text = "";
                operation = ' ';
                result = 0;
                num1 = 0;
                label2.Visible = false;
                
            }
            else
            {
                if (lcd_calc.Text != "")
                {
                    lcd_calc.Text = lcd_calc.Text.Remove(lcd_calc.Text.ToString().Length - 1);
                    if (lcd_calc.Text == "")
                        operation = ' ';
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            setNumber("3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setNumber(".");
        }



        private void no7_Click(object sender, EventArgs e)
        {
            setNumber("7");
        }

        private void no8_Click(object sender, EventArgs e)
        {
            setNumber("8");
        }

        private void no9_Click(object sender, EventArgs e)
        {
            setNumber("9");
        }

        private void no4_Click(object sender, EventArgs e)
        {
            setNumber("4");
        }

        private void no5_Click(object sender, EventArgs e)
        {
            setNumber("5");
        }

        private void no6_Click(object sender, EventArgs e)
        {
            setNumber("6");
        }

        private void no1_Click(object sender, EventArgs e)
        {
            setNumber("1");
        }

        private void no2_Click(object sender, EventArgs e)
        {
            setNumber("2");
        }

        private void rest_division_Click(object sender, EventArgs e)
        {
            setOperation('%');
        }

        private void delall_Click(object sender, EventArgs e)
        {
            lcd_calc.Text = "";
            operation = ' ';
            result = 0;
            num1 = 0;
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            setOperation('!');

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            setOperation('^');

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
