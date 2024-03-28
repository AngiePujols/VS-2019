using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
           


        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            domainUpDown2.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = domainUpDown2.SelectedIndex;
            domainUpDown2.Items.RemoveAt(n);
            domainUpDown2.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add("Manzana");
            domainUpDown1.Items.Add("Pera");
            domainUpDown1.Items.Add("Sandia");
            domainUpDown1.Items.Add("Mango");

            domainUpDown4.Items.Add("1");
            domainUpDown4.Items.Add("2");
            domainUpDown4.Items.Add("3");
            domainUpDown4.Items.Add("4");

            domainUpDown3.Items.Add("01");
            domainUpDown3.Items.Add("02");
            domainUpDown3.Items.Add("03");
            domainUpDown3.Items.Add("04");

            domainUpDown5.Items.Add("2015");
            domainUpDown5.Items.Add("2016");
            domainUpDown5.Items.Add("2017");
            domainUpDown5.Items.Add("2018");


        }
    }
}
