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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" ||
                textBox7.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Digite todos los valores solicitados", "Incompleto");
            }
            else
            {
                int indice = dataGridView1.Rows.Add();
                int ind = comboBox1.SelectedIndex;
                dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[indice].Cells[1].Value = textBox4.Text;
                dataGridView1.Rows[indice].Cells[2].Value = textBox6.Text;
                dataGridView1.Rows[indice].Cells[3].Value = textBox2.Text;
                dataGridView1.Rows[indice].Cells[4].Value = comboBox1.Items[ind].ToString();
                dataGridView1.Rows[indice].Cells[5].Value = textBox3.Text;
                dataGridView1.Rows[indice].Cells[6].Value = textBox5.Text;
                dataGridView1.Rows[indice].Cells[7].Value = textBox7.Text;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                comboBox1.SelectedIndex = -1;
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
            comboBox1.SelectedIndex = -1;
        }
    }
}
