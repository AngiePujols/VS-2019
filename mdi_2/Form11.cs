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
    public partial class Form11 : Form
    {
        private int list = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");


            string datos = "select * from Productos";

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
            if (textBox_ID.Text == "" || textBox_Nombre.Text == "" || textBox_Proveedor.Text == "" || textBox_PrecioUnitario.Text == "" || textBox_Cantidad.Text == "" || textBox_UnidadesStock.Text == "" || textBox_UnidadesCamino.Text == "" || textBox_Descontinuados.Text == "")
            {
                MessageBox.Show("No puede dejar nada vacio");
            }
            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string id = textBox_ID.Text;
                string nombre_Producto = textBox_Nombre.Text;
                string proveedor = textBox_Proveedor.Text;
                string precio_Unitario = textBox_PrecioUnitario.Text;
                string cantidad = textBox_Cantidad.Text;
                string Unidades_Stock = textBox_UnidadesStock.Text;
                string Unidades_Camino = textBox_UnidadesCamino.Text;
                string Descontinuados = textBox_Descontinuados.Text;
               

                string query = "Insert into Productos(ID_Productos,Producto_Nombre,Proveedor,Precio_Unitario,Cantidad,Unidades_Stock,Unidaes_Camino,Descontinuados) Values('" + id + "','" + nombre_Producto + "','" + proveedor + "','" + precio_Unitario + "','" + cantidad + "','" + Unidades_Stock + "','" + Unidades_Camino + "','" + Descontinuados + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBox_ID.Text = "";
                textBox_Nombre.Text = "";
                textBox_Proveedor.Text = "";
                textBox_PrecioUnitario.Text = "";
                textBox_Cantidad.Text = "";
                textBox_UnidadesStock.Text = "";
                textBox_UnidadesCamino.Text = "";
                textBox_Descontinuados.Text = "";
                textBox_ID.Focus();
                dataGridView1.Refresh();

            }
            }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_Nombre.Text = "";
            textBox_Proveedor.Text = "";
            textBox_PrecioUnitario.Text = "";
            textBox_Cantidad.Text = "";
            textBox_UnidadesStock.Text = "";
            textBox_UnidadesCamino.Text = "";
            textBox_Descontinuados.Text = "";
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
            string cadena = "select ID_Productos, Producto_Nombre, Proveedor, Precio_Unitario, Cantidad, Unidades_Stock,Unidaes_Camino,Descontinuados from Productos where ID_Productos=" + ID;
            SqlCommand command = new SqlCommand(cadena, Conectar);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_Nombre.Text = reader["Producto_Nombre"].ToString();
                textBox_Proveedor.Text = reader["Proveedor"].ToString();
                textBox_PrecioUnitario.Text = reader["Precio_Unitario"].ToString();
                textBox_Cantidad.Text = reader["Cantidad"].ToString();
                textBox_UnidadesStock.Text = reader["Unidades_Stock"].ToString();
                textBox_UnidadesCamino.Text = reader["Unidaes_Camino"].ToString();
                textBox_Descontinuados.Text = reader["Descontinuados"].ToString();

            }
        }
    }
}
