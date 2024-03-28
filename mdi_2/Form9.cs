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

namespace mdi
{
    public partial class Form9 : Form
    {
        private int list = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            comboBox_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");


            string datos = "select * from Cliente";

            try
            {
                conectar.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conectar.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "" || textBox_Nombre.Text == "" || textBox_Apellido.Text == "" || text_Fecha.Text == "" || text_Telefono.Text == "" || text_Direccion.Text == "" || comboBox_Sexo.Text == "" || textBox_Email.Text == "")
            {
                MessageBox.Show("No puede dejar nada vacio");
            }
            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string id = textBox_ID.Text;
                string nombre = textBox_Nombre.Text;
                string Apellido = textBox_Apellido.Text;
                string Fecha = text_Fecha.Text;
                string Telefono = text_Telefono.Text;
                string Direccion = text_Direccion.Text;
                string Sexo = comboBox_Sexo.Text;
                string Email = textBox_Email.Text;
                string query = "Insert into Cliente(ID_Cliente,Nombre,Apellido,Fecha_de_Nacimiento,Sexo,Telefono,Direccion,Email) Values('" + id + "','" + nombre + "','" + Apellido + "','" + Fecha + "','" + Sexo + "','" + Telefono + "','" + Direccion + "','" + Email + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBox_ID.Text = "";
                textBox_Nombre.Text = "";
                textBox_Apellido.Text = "";
                text_Fecha.Text = "";
                text_Telefono.Text = "";
                text_Direccion.Text = "";
                comboBox_Sexo.Text = "";
                textBox_Email.Text = "";
                textBox_ID.Focus();
                dataGridView1.Refresh();
               

            }


        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            text_Fecha.Text = "";
            comboBox_Sexo.SelectedIndex = -1;
            text_Telefono.Text = "";
            text_Direccion.Text = "";
            textBox_Email.Text = "";
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            if (list != -1)
            {
                dataGridView1.Rows.RemoveAt(list);
            }

        }

        private void comboBox_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string SQL = "Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True";
            SqlConnection Conectar = new SqlConnection(SQL);
            Conectar.Open();
            String ID = textBox_ID.Text;
            //string Departamento = textBox2.Text;
            //string Descripcion = textBox3.Text;
            string cadena = "select ID_Cliente,Nombre,Apellido,Fecha_de_Nacimiento,Sexo,Telefono,Direccion,Email from cliente where ID_Cliente=" + ID;
            SqlCommand command = new SqlCommand(cadena, Conectar);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_Nombre.Text = reader["Nombre"].ToString();
                textBox_Apellido.Text = reader["Apellido"].ToString();
                text_Fecha.Text = reader["Fecha_de_nacimiento"].ToString();
                text_Telefono.Text = reader["Telefono"].ToString();
                text_Direccion.Text = reader["Direccion"].ToString();
                comboBox_Sexo.Text = reader["Sexo"].ToString();
                textBox_Email.Text = reader["Email"].ToString();
                
            }
        }

        private void button_Modificar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();
            string id = textBox_ID.Text;
            string nombre = textBox_Nombre.Text;
            string apellido = textBox_Apellido.Text;
            string telefono = text_Telefono.Text;
            string fecha = text_Fecha.Text;
            string direccion = text_Direccion.Text;
            string sexo = comboBox_Sexo.Text;
            string email = textBox_Email.Text;
            string actualizar = "update Cliente set ID_Cliente = '" + id + "', Nombre = '" + nombre + "', Apellido = '" + apellido + "', Fecha_de_Nacimiento = '" + fecha + "', Sexo = '" + sexo + "', Telefono = '" + telefono + "', Direccion = '" + direccion + "', Email = '" + email + "' where ID_Cliente = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(actualizar, conectar);
            int controlador;
            controlador = cmd.ExecuteNonQuery();
            if (controlador == 1)
            {
                MessageBox.Show("Fueron modificados los Datos");
                textBox_Apellido.Text = "";
                textBox_Email.Text = "";
                textBox_ID.Text = "";
                textBox_Nombre.Text = "";
                text_Direccion.Text = "";
                text_Fecha.Text = "";
                comboBox_Sexo.Text = "";
                text_Telefono.Text = "";
                button_Modificar.Enabled = false;

            }

            else
            {
                MessageBox.Show("No se pudo modificar los Datos");
                conectar.Close();
            }
            string datos = "select * from Cliente";
            SqlConnection Conectando = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");

            try
            {
                Conectando.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                Conectando.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void text_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void text_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void text_Fecha_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                button_Modificar.Enabled = true;
            }

            else
            {
                button_Modificar.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
