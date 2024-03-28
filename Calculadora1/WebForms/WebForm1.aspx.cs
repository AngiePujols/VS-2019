using System;
using System.Linq;

namespace Calculadora1.WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Enabled = false;

        }

        protected void Bt7_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "7";
        }

        protected void Bt8_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "8";

        }

        protected void Bt9_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "9";
        }

        protected void Bt4_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "4";
        }

        protected void Bt5_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "5";
        }

        protected void Bt6_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "6";
        }

        protected void Bt1_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "1";
        }

        protected void Bt2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = Bt2.Text;
            }else
            {
                this.TextBox1.Text = TextBox1.Text + Bt2.Text;
            }
            
        }

        protected void Bt3_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "3";
        }

        protected void Bt0_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "0";
            
        }

        protected void BtPunto_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                this.TextBox1.Text += ".";
            }
        }

        protected void BtSigno_Click(object sender, EventArgs e)
        {
            
            if (TextBox1.Text.Length > 0)
            {
                string s = TextBox1.Text;
                TextBox1.Text = "(-" + s ;
            }

            else
            {
                this.TextBox1.Text += "(-";
            }
           
        }

        protected void BtPi_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "π";
        }

        protected void BtSuma_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                this.TextBox1.Text = TextBox1.Text + "+";
                BtSuma.Enabled = false;
            }
        
                  


           
        }
        
        protected void BtResta_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                this.TextBox1.Text += "-";
                BtResta.Enabled = false;
            }
      
        }

        protected void BtPor_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                this.TextBox1.Text += "*";
                BtPor.Enabled = false;
            }
           
        }

        protected void BtCL_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void BtDEL_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }

            TextBox1.Text = s;
        }

      
        protected void BtDiv_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                this.TextBox1.Text +="/";
                BtDiv.Enabled = false;
            }
            
        }

        protected void BtResultado_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Contains("+"))
            {
                var numbers = TextBox1.Text.Split('+').Select(double.Parse).ToList();
                TextBox1.Text = TextBox1.Text + " = ";
                double sum = numbers[0] + numbers[1];
                TextBox1.Text = Convert.ToString(sum);
                BtSuma.Enabled = true;

            }

            if (TextBox1.Text.Contains("-"))
            {
                var numbers = TextBox1.Text.Split('-').Select(double.Parse).ToList();
                TextBox1.Text = TextBox1.Text + " = ";
                double rest = numbers[0] - numbers[1];
                TextBox1.Text = Convert.ToString(rest);
                BtResta.Enabled = true;

            }

            if (TextBox1.Text.Contains("*"))
            {
                var numbers = TextBox1.Text.Split('*').Select(double.Parse).ToList();
                TextBox1.Text = TextBox1.Text + " = ";
                double multi = numbers[0] * numbers[1];
                TextBox1.Text = Convert.ToString(multi);
                BtPor.Enabled = true;

            }

            if (TextBox1.Text.Contains("/"))
            {
                var numbers = TextBox1.Text.Split('/').Select(double.Parse).ToList();
                TextBox1.Text = TextBox1.Text + " = ";
                double divi = numbers[0] / numbers[1];
                TextBox1.Text = Convert.ToString(divi);
                BtDiv.Enabled = true;

            }
        }

    }
}