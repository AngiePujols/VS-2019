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
    public partial class Form12 : Form
    {
        private int list = 0;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");


            string datos = "select * from Departamentos";

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "" || textBox_Departamantos.Text == "" || textBox_Descripcion.Text == "" || textBox_Telefono.Text == "" || textBox_Email.Text == "" || textBox_Fecha.Text == "")
            {
                MessageBox.Show("No puede dejar nada vacio");
            }
            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string id = textBox_ID.Text;
                string Departamentos = textBox_Departamantos.Text;
                string Descripcion = textBox_Descripcion.Text;
                string Telefono = textBox_Telefono.Text;
                string Fecha_De_Inicio = textBox_Fecha.Text;
                string Email = textBox_Email.Text;

                string query = "Insert into Departamentos (ID_Departamentos,Departamentos,Descripcion,Telefono,Fecha_de_Inicio,Email) Values('" + id + "','" + Departamentos + "','" + Descripcion + "','" + Telefono + "','" + Fecha_De_Inicio + "','" + Email + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBox_ID.Text = "";
                textBox_Departamantos.Text = "";
                textBox_Descripcion.Text = "";
                textBox_Telefono.Text = "";
                textBox_Fecha.Text = "";
                textBox_Email.Text = "";
                textBox_ID.Focus();
                dataGridView1.Refresh();

            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_Departamantos.Text = "";
            textBox_Descripcion.Text = "";
            textBox_Telefono.Text = "";
            textBox_Fecha.Text = "";
            textBox_Email.Text = "";
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
            string cadena = "select ID_Departamentos,Departamentos,Descripcion,Telefono,Fecha_de_Inicio,Email from Departamentos where ID_Departamentos=" + ID;
            SqlCommand command = new SqlCommand(cadena, Conectar);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_Departamantos.Text = reader["Departamentos"].ToString();
                textBox_Descripcion.Text = reader["Descripcion"].ToString();
                textBox_Telefono.Text = reader["Telefono"].ToString();
                textBox_Fecha.Text = reader["Fecha_de_Inicio"].ToString();
                textBox_Email.Text = reader["Email"].ToString();
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
