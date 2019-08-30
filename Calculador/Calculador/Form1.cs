using System;
using System.Windows.Forms;

namespace Calculador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string c;

        private void Button0_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "0";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "1";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "2";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "3";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "4";
            }
            else
            {
               tbResultado.Text = tbResultado.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "5";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "6";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "7";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "8";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = "9";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + "9";
            }
        }

        private void btpors(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.tbResultado.Text);
            c = "%";
            this.tbResultado.Text = Convert.ToString(a / 100);
            this.tbResultado.Focus();
        }

        private void btpunt(object sender, EventArgs e)
        {
            if (tbResultado.Text == "")
            {
                tbResultado.Text = ".";
            }
            else
            {
                tbResultado.Text = tbResultado.Text + ".";
            }
        }

        private void btdiv(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.tbResultado.Text);
            c = "/";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btmult(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.tbResultado.Text);
            c = "*";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btsum(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.tbResultado.Text);
            c = "+";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btres(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.tbResultado.Text);
            c = "-";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btCE(object sender, EventArgs e)
        {
            a = Convert.ToDouble("");
            b = Convert.ToDouble("");
            this.tbResultado.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text.Length == 1)
                tbResultado.Text = "";
            else
                tbResultado.Text = tbResultado.Text.Substring(0, tbResultado.Text.Length - 1);
        }

        private void btIgual(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.tbResultado.Text);
            switch (c)
            {
                case "+":
                    this.tbResultado.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.tbResultado.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.tbResultado.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.tbResultado.Text = Convert.ToString(b / a);
                    break;
            }
        }
    }
}
