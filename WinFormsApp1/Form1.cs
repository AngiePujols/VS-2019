using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            button2.Visible = true; 
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            Salida.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Cambio";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre";
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Salida.Text = "Welcome";
            label1.Text = "Name";
            button1.Text = "Agree";
            button2.Text = "Cancel";
            Cambiar.Text = "Change";
            button4.Text = "Translate";
            button3.Text = "Edit";
        }
    }
}
