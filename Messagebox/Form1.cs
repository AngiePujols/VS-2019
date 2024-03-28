using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola","Bienvenidos");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saludo 2", "Caja de Saludos 2", MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Saludo 3", "Caja de Saludos 3", MessageBoxButtons.AbortRetryIgnore);
            DialogResult Result= MessageBox.Show("Saludo 3", "Caja de Saludos 3", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
            if(Result == DialogResult.Abort)
            {
                label1.Text = "Abort";
            }
            if (Result == DialogResult.Retry)
            {
                label1.Text = "Retry";
            }
            if (Result == DialogResult.Ignore)
            {
                label1.Text = "Ignore";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           DialogResult Resultado = MessageBox.Show("Desea Salir?", "Caja de Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
