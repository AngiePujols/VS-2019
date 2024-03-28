using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class Form4 : Form
    {
        int a;
        int b;
        int bp;
        int bc;
        int c;
        int d;
        int ef;

        public Form4()
        {
            InitializeComponent();
            

        }
        //listbox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                textBox12.Enabled = true;

            }
            else if (listBox1.SelectedIndex == 2)
            {
                textBox11.Enabled = true;

            }
            else if (listBox1.SelectedIndex == 4)
            {
                textBox9.Enabled = true;

            }
            else if (listBox1.SelectedIndex == 6)
            {
                textBox4.Enabled = true;

            }
            else if (listBox1.SelectedIndex == 8)
            {
                textBox10.Enabled = true;

            }
        }

        //borrar, 
        private void button2_Click(object sender, EventArgs e)
        {



            if (label4.Text != "Prod1")
            {
                label4.Text = "Prod1";
                if (listBox1.SelectedIndex == 0)
                {
                    labPre1.Text = "";
                    label19.Text = "";
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre1.Text = "";
                    label19.Text = "";
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre1.Text = "";
                    label19.Text = "";
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre1.Text = "";
                    label19.Text = "";
                }
                else if (listBox1.SelectedIndex == 8)
                {
                    labPre1.Text = "";
                    label19.Text = "";
                }
            }
            else if (label5.Text != "Prod2")
            {
                label5.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre2.Text = "";
                    labC2.Text = "";
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre2.Text = "";
                    labC2.Text = "";
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre2.Text = "";
                    labC2.Text = "";
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre2.Text = "";
                    labC2.Text = "";
                }
                else if (listBox1.SelectedIndex == 8)
                {

                    labPre2.Text = "";
                    labC2.Text = "";
                }
            }
            else if (label6.Text != "Prod3")
            {
                label6.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre3.Text = "";
                    labC3.Text = "";
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre3.Text = p3.Text;
                    labC3.Text = textBox11.Text;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre3.Text = p4.Text;
                    labC3.Text = textBox9.Text;
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre3.Text = "";
                    labC2.Text = "";
                }
                else if (listBox1.SelectedIndex == 8)
                {

                    labPre3.Text = "";
                    labC3.Text = "";
                }

            }
            else if (label7.Text != "Prod4")
            {
                label7.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre4.Text = "";
                    labC4.Text = "";
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre4.Text = "";
                    labC4.Text = "";
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre4.Text = "";
                    labC4.Text = "";
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre4.Text = "";
                    labC4.Text = "";
                }
                else if (listBox1.SelectedIndex == 8)
                {

                    labPre4.Text = "";
                    labC4.Text = "";
                }
            }
            else if (label22.Text != "Prod5")
            {
                label22.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre5.Text = "";
                    labC5.Text = "";
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre5.Text = "";
                    labC5.Text = "";
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre5.Text = "";
                    labC5.Text = "";
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre5.Text = "";
                    labC5.Text = "";
                }
                else if (listBox1.SelectedIndex == 8)
                {
                    labPre5.Text = "";
                    labC5.Text = "";
                }
            }
            if (listBox1.SelectedIndex == 0)
            {
                a = 0;

            }

            if (listBox1.SelectedIndex == 2)
            {

                b = 0;

            }

            if (listBox1.SelectedIndex == 4)
            {
                c = 0;

            }

            if (listBox1.SelectedIndex == 6)
            {
                d = 0;

            }

            if (listBox1.SelectedIndex == 8)
            {
                ef = 0;

            }

        }

        //nombre, cantidad y precio agregar
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (label4.Text == "Prod1")
            {
                label4.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre1.Text = p2.Text;
                    label19.Text = textBox12.Text;
                }
               else if (listBox1.SelectedIndex == 2)
                {
                    labPre1.Text = p3.Text;
                    label19.Text = textBox11.Text;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre1.Text = p4.Text;
                    label19.Text = textBox9.Text;
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre1.Text = p5.Text;
                    label19.Text = textBox4.Text;
                }
                else if (listBox1.SelectedIndex == 8)
                {
                    labPre1.Text = p6.Text;
                    label19.Text = textBox10.Text;
                }
            }
            else if (label5.Text == "Prod2" )
            {
                label5.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre2.Text = p2.Text;
                    labC2.Text = textBox12.Text;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre2.Text = p3.Text;
                    labC2.Text = textBox11.Text;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre2.Text = p4.Text;
                    labC2.Text = textBox9.Text;
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre2.Text = p5.Text;
                    labC2.Text = textBox4.Text;
                }
                else if (listBox1.SelectedIndex == 8)
                {
                    
                    labPre2.Text = p6.Text;
                    labC2.Text = textBox10.Text;
                }
            }
            else if (label6.Text == "Prod3")
            {
                label6.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre3.Text = p2.Text;
                    labC3.Text = textBox12.Text;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre3.Text = p3.Text;
                    labC3.Text = textBox11.Text;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre3.Text = p4.Text;
                    labC3.Text = textBox9.Text;
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre3.Text = p5.Text;
                    labC2.Text = textBox4.Text;
                }
                else if (listBox1.SelectedIndex == 8)
                {

                    labPre3.Text = p6.Text;
                    labC3.Text = textBox10.Text;
                }

            }
            else if (label7.Text == "Prod4")
            {
                label7.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre4.Text = p2.Text;
                    labC4.Text = textBox12.Text;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre4.Text = p3.Text;
                    labC4.Text = textBox11.Text;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre4.Text = p4.Text;
                    labC4.Text = textBox9.Text;
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre4.Text = p5.Text;
                    labC4.Text = textBox4.Text;
                }
                else if (listBox1.SelectedIndex == 8)
                {

                    labPre4.Text = p6.Text;
                    labC4.Text = textBox10.Text;
                }
            }
            else if (label22.Text == "Prod5")
            {
                label22.Text = (string)listBox1.SelectedItem;
                if (listBox1.SelectedIndex == 0)
                {
                    labPre5.Text = p2.Text;
                    labC5.Text = textBox12.Text;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    labPre5.Text = p3.Text;
                    labC5.Text = textBox11.Text;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    labPre5.Text = p4.Text;
                    labC5.Text = textBox9.Text;
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    labPre5.Text = p5.Text;
                    labC5.Text = textBox4.Text;
                }
                else if (listBox1.SelectedIndex == 8)
                {
                    labPre5.Text = p6.Text;
                    labC5.Text = textBox10.Text;
                }
            }


            //calculo

            if (listBox1.SelectedIndex == 0)
            {
                a = Convert.ToInt32(p2.Text) * Convert.ToInt32(textBox12.Text);
                
            }

            if (listBox1.SelectedIndex == 2)
            {
                bp = Convert.ToInt32(p3.Text);
                bc =Convert.ToInt32(textBox11.Text);
                b = bp * bc;
                
            }

            if (listBox1.SelectedIndex == 4)
            {
                c = Convert.ToInt32(p4.Text) * Convert.ToInt32(textBox9.Text);
                
            }

            if (listBox1.SelectedIndex == 6)
            {
                d = Convert.ToInt32(p5.Text) * Convert.ToInt32(textBox4.Text);
                
            }
            
            if (listBox1.SelectedIndex == 8)
            {
                 ef = Convert.ToInt32(p6.Text) * Convert.ToInt32(textBox10.Text);
                    
            }

            int to;
            to = (a + b + c + d + ef);

            labpagar.Text = to.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (comboB.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente");

            }
            else
            {
                int nom = comboB.SelectedIndex;
                label11.Text = comboB.Items[nom].ToString();
                groupBox1.Visible = true;
                timer1.Enabled = true;
                DateTime fecha = DateTime.Now;
                labfecha.Text = fecha.ToString();
            }



        }

        


        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
