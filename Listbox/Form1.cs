using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listproducts.SelectedIndex >= 0)
            {
                label1.Text = (string)Listproducts.Items[Listproducts.SelectedIndex];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listproducts.Items.Add("Manzana");
            Listproducts.Items.Add("Pera");
            Listproducts.Items.Add("Naranja");
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Listproducts.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
            textBox1.Focus();

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int list = Listproducts.SelectedIndex;
            if (list >= 0)
            {
                Listproducts.Items.RemoveAt(list); 
            }
        }
    }
}
