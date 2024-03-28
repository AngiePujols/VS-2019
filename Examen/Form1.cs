using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Resultado;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Resultado = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
           
            button3.Enabled = false;
            Leon.Enabled = false;
            Elefante.Enabled = false;
            Tigre.Enabled = false;
            if (Leon.Checked == true)
            {
                groupBox1.BackColor = Color.LimeGreen;
                label6.Text = "Correcto";
               
                
            }

            if (Elefante.Checked == true)
            {
                label6.Text = "Incorrecto";
                groupBox1.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
            if (Tigre.Checked == true)
            {
                label6.Text = "Incorrecto";
                groupBox1.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            Digestivo.Enabled = false;
            Circulatorio.Enabled = false;
            Respiratorio.Enabled = false;
            if (Respiratorio.Checked == true)
            {
                groupBox3.BackColor = Color.LimeGreen;
                label7.Text = "Correcto";
              
            }

            if (Digestivo.Checked == true)
            {
                label7.Text = "Incorrecto";
                groupBox3.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
            if (Circulatorio.Checked == true)
            {
                label7.Text = "Incorrecto";
                groupBox3.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            D360.Enabled = false;
            D365.Enabled = false;
            D366.Enabled = false;
            if (D366.Checked == true)
            {
                groupBox2.BackColor = Color.LimeGreen;
                label9.Text = "Correcto";
                
            }

            if (D365.Checked == true)
            {
                label9.Text = "Incorrecto";
                groupBox2.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
            if (D360.Checked == true)
            {
                label9.Text = "Incorrecto";
                groupBox2.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            button4.Enabled = false;
            Verdad.Enabled = false;
            Falso.Enabled = false;
            if (Verdad.Checked == true)
            {
                groupBox5.BackColor = Color.LimeGreen;
                label10.Text = "Correcto";
               
            }

            if (Falso.Checked == true)
            {
                label10.Text = "Incorrecto";
                groupBox5.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            button5.Enabled = false;
            Paris.Enabled = false;
            Milan.Enabled = false;
            Roma.Enabled = false;
            if (Paris.Checked == true)
            {
                groupBox4.BackColor = Color.LimeGreen;
                label8.Text = "Correcto";
               
            }

            if (Milan.Checked == true)
            {
                label8.Text = "Incorrecto";
                groupBox4.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
            if (Roma.Checked == true)
            {
                label8.Text = "Incorrecto";
                groupBox4.BackColor = Color.Red;
                Resultado = Resultado - 20;
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nota.Text = Resultado.ToString() + "/100";
            if (Resultado >= 60)
                AOR.Text = "Aprobó";
            else
                AOR.Text = "Reprobo";


        }

    }
}
