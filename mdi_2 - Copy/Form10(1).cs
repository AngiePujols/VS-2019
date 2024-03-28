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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" ||
                textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || combo.SelectedIndex == -1)
            {
                MessageBox.Show("Digite todos los valores solicitados", "Incompleto");
            }
            else { 
            int indice = dataGridView1.Rows.Add();
            int indi = combo.SelectedIndex;
            dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[indice].Cells[1].Value = textBox4.Text;
            dataGridView1.Rows[indice].Cells[2].Value = textBox6.Text;
            dataGridView1.Rows[indice].Cells[3].Value = textBox2.Text;
            dataGridView1.Rows[indice].Cells[4].Value = combo.Items[indi].ToString();
            dataGridView1.Rows[indice].Cells[5].Value = textBox3.Text;
            dataGridView1.Rows[indice].Cells[6].Value = textBox5.Text;
            dataGridView1.Rows[indice].Cells[7].Value = textBox7.Text;
            dataGridView1.Rows[indice].Cells[8].Value = textBox8.Text;
            dataGridView1.Rows[indice].Cells[9].Value = textBox9.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }
}
