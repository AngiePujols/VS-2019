using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexionesSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                { lab2.Visible = true;
                lab3.Visible = true;
                lab3.Text = "Llenar todos los Campos";
                if(textBox2.Text != "")
                {
                    lab2.Visible = false;
                }
            }
              
            if(textBox2.Text != "")
            { lab1.Visible = true;
                lab3.Visible = true;
                lab3.Text = "Llenar todos los Campos";
                if (textBox1.Text != "")
                {
                    lab1.Visible = false;
                }
            }
            if(textBox1.Text !="" && textBox2.Text!="")

            {
                lab1.Visible = false;
                lab2.Visible = false;
                lab3.Text = "";

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
                conn.Open();
                string usuario = textBox1.Text;
                string clave = textBox2.Text;
                string sqluser = @"select count(*) from USUARIO where Usuario = @user and Contraseña = @clave ";
                SqlCommand cmd = new SqlCommand(sqluser, conn);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                int contador = Convert.ToInt32(cmd.ExecuteScalar());

                if (contador == 0)
                {

                    MessageBox.Show("Usuario o Clave Incorrecto");
                }
                else
                {
                    MessageBox.Show("Bienvenido al Sistema");
                    Form1 form = new Form1();
                    form.Show();
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
