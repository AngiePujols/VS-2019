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
    public partial class Form10 : Form
    {
        private int list = 0;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            comboBox_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");


            string datos = "select * from Empleados";

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

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "" || textBox_Nombre.Text == "" || textBox_Apellido.Text == "" || textBox_Fecha.Text == "" || textBox_Telefono.Text == "" || textBox_Direccion.Text == "" || textBox_Puesto.Text == "" || comboBox_Sexo.Text == "" || textBox_ID_Departamento.Text == "")
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
                string Fecha = textBox_Fecha.Text;
                string Telefono = textBox_Telefono.Text;
                string Direccion = textBox_Direccion.Text;
                string Sexo = comboBox_Sexo.Text;
                string Puesto = textBox_Puesto.Text;
                string Id_Departamento = textBox_ID_Departamento.Text;

                string query = "Insert into Empleados(ID_Empleados,Nombre,Apellido,Fecha_de_Nacimiento,Sexo,Telefono,Puesto,ID_Departamento,Direccion) Values('" + id + "','" + nombre + "','" + Apellido + "','" + Fecha + "','" + Sexo + "','" + Telefono + "','" + Puesto + "','" + Id_Departamento + "','" + Direccion + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBox_ID.Text = "";
                textBox_Nombre.Text = "";
                textBox_Apellido.Text = "";
                textBox_Telefono.Text = "";
                textBox_Fecha.Text = "";
                textBox_Direccion.Text = "";
                comboBox_Sexo.Text = "";
                textBox_Puesto.Text = "";
                textBox_ID_Departamento.Text = "";

                textBox_ID.Focus();
                dataGridView1.Refresh();


            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_Fecha.Text = "";
            comboBox_Sexo.SelectedIndex = -1;
            textBox_Telefono.Text = "";
            textBox_Puesto.Text = "";
            textBox_ID_Departamento.Text = "";
            textBox_Direccion.Text = "";
          
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            if (list != -1)
            {
                dataGridView1.Rows.RemoveAt(list);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True";
            SqlConnection Conectar = new SqlConnection(SQL);
            Conectar.Open();
            String ID = textBox_ID.Text;
            //string Departamento = textBox2.Text;
            //string Descripcion = textBox3.Text;
            string cadena = "select ID_Empleados, Nombre, Apellido, Fecha_de_Nacimiento, Sexo, Telefono, Puesto, ID_Departamento, Direccion from Empleados where ID_Departamento = " + ID;
            SqlCommand command = new SqlCommand(cadena, Conectar);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_Nombre.Text = reader["Nombre"].ToString();
                textBox_Apellido.Text = reader["Apellido"].ToString();
                textBox_Fecha.Text = reader["Fecha_de_nacimiento"].ToString();
                comboBox_Sexo.Text = reader["Sexo"].ToString();
                textBox_Telefono.Text = reader["Telefono"].ToString();
                textBox_Puesto.Text = reader["Puesto"].ToString();
                textBox_ID_Departamento.Text = reader["ID_Departamento"].ToString();
                textBox_Direccion.Text = reader["Direccion"].ToString();
           

            }
        }

        private void comboBox_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
