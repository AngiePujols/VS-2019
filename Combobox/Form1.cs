using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            label3.Text = indice.ToString();
            label4.Text = comboBox1.Items[indice].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Fresas");
            comboBox1.Items.Add("Chocolate");
            comboBox1.Items.Add("Vainilla");
            comboBox1.Items.Add("Menta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El mouse esta aqui arriba");
        }
        
    }
}
