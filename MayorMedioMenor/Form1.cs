using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorMedioMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num1 = comboBox1.SelectedIndex;
            int num2 = comboBox2.SelectedIndex;
            int num3 = comboBox3.SelectedIndex;

            if (num1 == num2 && num2 == num3 && num3 == num1)
            {
                MessageBox.Show("Todos los números son iguales");

            }

            if (num1 == num2 && !(num2 == num3) && !(num3 == num1))
            {
                MessageBox.Show("Hay dos números que son iguales");
               
            }

            if (num3 == num1 && !(num2 == num3) && !(num1 == num2))
            {
                MessageBox.Show("Hay dos números que son iguales");

            }

            if (num2 == num3 && !(num3 == num1) && !(num1 == num2))
            {
                MessageBox.Show("Hay dos números que son iguales");

            }

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {

                MessageBox.Show("No pude dejar nada vacio Por Favor ingresar valores");

            }

                else
                { 
                if (num1 > num2 && num1 > num3 && num2 > num3)
                {
                    label4.Text = "Este es Mayor";
                    label3.Text = "Este es Medio";
                    label1.Text = "Este es Menor";
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;

                }
                if (num2 > num1 && num3 > num1 && num3 > num2)
                {
                    label4.Text = "Este es Menor";
                    label3.Text = "Este es Medio";
                    label1.Text = "Este es Mayor";
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;

                }

                if (num1 > num2 && num1 > num3 && num2 > num3)
                {
                    label4.Text = "Este es Mayor";
                    label3.Text = "Este es Menor";
                    label1.Text = "Este es Medio";
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;

                }

                if (num2 > num1 && num2 > num3 && num3 > num1)
                {
                    label4.Text = "Este es Menor";
                    label3.Text = "Este es Mayor";
                    label1.Text = "Este es Medio";
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;

                }

                if (num3 > num1 && num3 > num2 && num1 > num2)
                {
                    label4.Text = "Este es Medio";
                    label3.Text = "Este es Menor";
                    label1.Text = "Este es Mayor";
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                }



                if (num1 > num3 && num3 > num2 && num1 > num2)
                {
                    label4.Text = "Este es Mayor";
                    label3.Text = "Este es Menor";
                    label1.Text = "Este es Medio";
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}       
