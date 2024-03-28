using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox1.Text = "150";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                textBox1.Text = "200";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            int monto = Convert.ToInt32(textBox1.Text);
            if (checkBox1.Checked == true)
                monto += 40;
            if (checkBox3.Checked == true)
                monto += 30;
            if (checkBox2.Checked == true)
                monto += 60;
            label2.Text = "El precio a pagar es: "+monto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            textBox1.Text = " ";
            label2.Visible = false;

        }
    }
}
