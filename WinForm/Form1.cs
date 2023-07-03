using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(this.textBox.Text!= "Syntax Error")
                this.textBox.Text += button.Text;
            else
                this.textBox.Text = button.Text;
            this.textBox1.Text = "";
        }
        private void btn_Operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //this.op=button.Text;
            string[] splitVirgule = this.textBox.Text.Split(',');
            int numberSplit=splitVirgule.Length;
            if (numberSplit > 2 || this.textBox.Text.Length==0)
            {
                this.textBox.Text = "Syntax Error";
            }
            else
            {
                
                this.result = Convert.ToDouble(this.textBox.Text);
                this.textBox.Text = "";
                this.op = button.Text;
            }
            this.textBox1.Text = "";
        }
        private void btn_Equal(object sender, EventArgs e)
        {
            if (!this.op.Equals(""))
            {
                string[] splitTextBox = this.textBox.Text.Split(',');
                if (splitTextBox.Length > 2)
                {
                    this.textBox.Text = "Syntax Error";
                }
                else
                {
                    bool status=true;
                    double lastResult = this.result;
                    double actuelResult = Convert.ToDouble(this.textBox.Text);
                    switch (this.op)
                    {
                        case "x":
                            this.result *= Convert.ToDouble(this.textBox.Text);
                            break;
                        case "+":
                            this.result += Convert.ToDouble(this.textBox.Text);
                            break;
                        case "-":
                            this.result -= Convert.ToDouble(this.textBox.Text);
                            break;
                        case "/":
                            if (Convert.ToDouble(this.textBox.Text) == 0)
                            {
                                status = false;
                            }
                            else
                            {
                                this.result /= Convert.ToDouble(this.textBox.Text);
                            }
                            break;
                        case "^":
                            if (this.result == 0)
                            {
                                status = false;
                            }
                            else
                            {
                                this.result = Math.Pow(this.result, Convert.ToDouble(this.textBox.Text));
                            }
                            break;
                    }
                    if (status==true)
                    {
                        this.textBox.Text = Convert.ToString(this.result);
                        this.textBox1.Text = $"{lastResult} {this.op} {actuelResult} = {this.result}";
                        this.op = "";
                    }
                    else
                    {
                        this.textBox.Text = "Syntax Error";
                        this.textBox1.Text = "";
                        this.op = "";
                    }
                    
                }
            }
        }
        private void btn_C_CE(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text.Equals("C"))
            {
                this.textBox.Text = "";
            }else if (button.Text.Equals("CE"))
            {
                if (this.textBox.Text.Length > 0)
                {
                    this.textBox.Text = this.textBox.Text.Substring(0, this.textBox.Text.Length - 1);
                }     
            }
            this.textBox1.Text = "";
        }
        private void btn_plus_minus(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string[] splitTextBox = this.textBox.Text.Split(',');
            if (splitTextBox.Length > 2)
            {
                this.textBox.Text = "Syntax Error";
            }
            else
            {
                if (this.textBox.Text[0] == '-')
                {
                    this.textBox.Text = this.textBox.Text.Substring(1);
                }
                else
                {
                    this.textBox.Text = "-" + this.textBox.Text;
                }
            }
            this.textBox1.Text = "";

        }

        //private void btn_equal(object sender, EventArgs e)
        //{
            
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
