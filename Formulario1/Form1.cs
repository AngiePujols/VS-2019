using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1, num2,Resultado;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox2.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            Resultado = num1 - num2;
            //MessageBox.Show("El Resultado de la Resta es: " + Resultado);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox2.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            Resultado = num1 / num2;
            //MessageBox.Show("El Resultado de la División es: " + Resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox2.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            Resultado = num1 + num2;
            //MessageBox.Show("El Resultado de la Suma es: " + Resultado);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 
            label6.Text = "Femenino";

            if (radioButton2.Checked == true) 
            label6.Text = "Masculino";

            if (radioButton3.Checked == true) 
            label6.Text = "No se";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            num1 = Convert.ToInt32(textBox2.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            Resultado = num1 * num2;
            //MessageBox.Show("El Resultado de la Multiplicación es: " + Resultado);
            label7.Text = Resultado.ToString();
            textBox3.Text = Resultado.ToString();

        }
    }
}
