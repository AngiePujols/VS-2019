using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class Form1 : Form
    {
        private int list = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar valores a los campos 
            int indice = dataGridView1.Rows.Add();

            // Colocando los Datosen el GV

            dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[indice].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[indice].Cells[2].Value = textBox3.Text;

            textBox1.Focus();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            if(list != -1)
            {
                dataGridView1.Rows.RemoveAt(list);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list = e.RowIndex;

            if (list != -1)
            {
                label4.Text = (string)dataGridView1.Rows[list].Cells[0].Value;
            }


        }
    }
}
