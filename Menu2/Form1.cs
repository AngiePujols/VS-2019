using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1, num2, Resultado;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            Resultado = num1 + num2;
            textBox3.Text = ""+Resultado;
            label4.Text = "Suma";
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1, num2, Resultado;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            Resultado = num1 - num2;
            textBox3.Text = "" + Resultado;
            label4.Text = "Resta";
        }

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double num1, num2, Resultado;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            Resultado = num1 / num2;
            textBox3.Text = "" + Resultado;
            label4.Text = "Division";
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1, num2, Resultado;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            Resultado = num1 * num2;
            textBox3.Text = "" + Resultado;
            label4.Text = "Multiplicacion";
        }
    }
}
