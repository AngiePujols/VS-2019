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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Digite todos los valores solicitados", "Incompleto");
            }
            else { 
            int indice = dataGridView1.Rows.Add();
        
            dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[indice].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[indice].Cells[2].Value = textBox3.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
