using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        private int list = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Matemáticas");
            comboBox1.Items.Add("Español");
            comboBox1.Items.Add("Naturales");
            comboBox1.Items.Add("Sociales");
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list != -1)
            {
                dataGridView1.Rows.RemoveAt(list);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list = e.RowIndex;

            if (list != -1)
            {
                label4.Text = (string)dataGridView1.Rows[list].Cells[0].Value;
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, PromedioM, PromedioN, PromedioE, PromedioS;
            n1 = Convert.ToDouble(nota1.Text);  
            n2 = Convert.ToDouble(nota2.Text);
            n3=  Convert.ToDouble(nota3.Text);
            n4 = Convert.ToDouble(nota4.Text);
           

            if (comboBox1.Text == "Sociales")
            {
                PromedioS = (n1 + n2 + n3 + n4) / 4;
                groupBox4.Visible = true;
                label12.Visible = true;
                label12.Text = Convert.ToString(PromedioS);
     

            }

            if (comboBox1.Text == "Matemáticas")
            {
                PromedioM = (n1 + n2 + n3 + n4) / 4;
                groupBox3.Visible = true;
                label11.Visible = true;
                label11.Text = Convert.ToString(PromedioM);
            

            }

            if (comboBox1.Text == "Español")
            {
                PromedioE = (n1 + n2 + n3 + n4) / 4;
                groupBox1.Visible = true;
                label9.Visible = true;
                label9.Text = Convert.ToString(PromedioE);
            

            }
           
            if (comboBox1.Text == "Naturales")
            {
                PromedioN = (n1 + n2 + n3 + n4) / 4;
                groupBox2.Visible = true;
                label10.Visible = true;
                label10.Text = Convert.ToString(PromedioN);

            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Opción");

            }



        }

        private void natu_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Soc_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Agregar valores a los campos 
            int indice = dataGridView1.Rows.Add();
            double n1, n2, n3, n4,PromedioTotal,P1,P2,P3,P4;
            n1 = Convert.ToDouble(nota1.Text);  
            n2 = Convert.ToDouble(nota2.Text);
            n3=  Convert.ToDouble(nota3.Text);
            n4 = Convert.ToDouble(nota4.Text);
            DateTime now = DateTime.Now;
            DateTime givenDate = DateTime.Parse(textBox3.Text);
            P1 = Convert.ToDouble(label11.Text);
            P2 = Convert.ToDouble(label10.Text);
            P3 = Convert.ToDouble(label12.Text);
            P4 = Convert.ToDouble(label9.Text);
            int days = now.Subtract(givenDate).Days;
            double age = Math.Floor(days / 365.24219);
            PromedioTotal = (P1 + P2 + P3 + P4) / 4;
            

            // Colocando los Datosen el GV

            dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[indice].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[indice].Cells[4].Value = textBox4.Text;
            dataGridView1.Rows[indice].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[indice].Cells[3].Value = age;
            dataGridView1.Rows[indice].Cells[5].Value = label11.Text;
            dataGridView1.Rows[indice].Cells[6].Value = label10.Text;
            dataGridView1.Rows[indice].Cells[7].Value = label12.Text;
            dataGridView1.Rows[indice].Cells[8].Value = label9.Text;
            dataGridView1.Rows[indice].Cells[9].Value = PromedioTotal;

            textBox1.Focus();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
            nota4.Text = "";
            comboBox1.Text = "";

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
