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
    public partial class Form7 : Form
    {
        private int list = 0;
        public Form7()
        {
            InitializeComponent();
        }

      

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");


            string datos = "select * from Compras";

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
            if (textBox_ID.Text == "" || textBox_Producto.Text == "" || textBox_Precio.Text == "" || textBox_Cantidad.Text == "" || textBox_Fecha.Text == "" || textBox_Proveedor.Text == "")
            {
                MessageBox.Show("No puede dejar nada vacio");
            }

            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string id = textBox_ID.Text;
                string Nombre_Producto = textBox_Producto.Text;
                string Precio_Unitario = textBox_Precio.Text;
                string Cantidad = textBox_Cantidad.Text;
                string Fecha = textBox_Fecha.Text;
                string Proveedor = textBox_Proveedor.Text;

                string query = "Insert into Compras (ID_Compras,Producto_Nombre,Precio_Unitario,Cantidad,Fecha,Proveedor) Values('" + id + "','" + Nombre_Producto + "','" + Precio_Unitario + "','" + Cantidad + "','" + Fecha + "','" + Proveedor + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBox_ID.Text = "";
                textBox_Producto.Text = "";
                textBox_Proveedor.Text = "";
                textBox_Precio.Text = "";
                textBox_Cantidad.Text = "";
                textBox_Fecha.Text = "";
                textBox_ID.Focus();
                dataGridView1.Refresh();

            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_Producto.Text = "";
            textBox_Precio.Text = "";
            textBox_Cantidad.Text = "";
            textBox_Fecha.Text = "";
            textBox_Proveedor.Text = "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True";
            SqlConnection Conectar = new SqlConnection(SQL);
            Conectar.Open();
            String ID = textBox_ID.Text;
            //string Departamento = textBox2.Text;
            //string Descripcion = textBox3.Text;
            string cadena = "select ID_Compras,Producto_Nombre,Precio_Unitario,Cantidad,Fecha, Proveedor from Compras where ID_Compras=" + ID;
            SqlCommand command = new SqlCommand(cadena, Conectar);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_Producto.Text = reader["Producto_Nombre"].ToString();
                textBox_Precio.Text = reader["Precio_Unitario"].ToString();
                textBox_Cantidad.Text = reader["Cantidad"].ToString();
                textBox_Fecha.Text = reader["Fecha"].ToString();
                textBox_Proveedor.Text = reader["Proveedor"].ToString();

            }
        }
    }
}
