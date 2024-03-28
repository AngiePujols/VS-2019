using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        public int contador;
        private Timer ti;

        public Form1()
        {
            InitializeComponent();
            contador = 0;
            ti = new Timer();
            ti.Tick += new EventHandler(Form1_Load);
            ti.Enabled = true;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tiempo.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tiempo.Enabled = false;
            trackBar1.Value = trackBar1.Minimum;
            label1.Text = "0";
            label3.Text = "0";
            contador = 0;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            Tiempo.Interval = trackBar1.Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            label4.Text = fecha.ToString("hh:mm:ss tt");
        }
    }
}
