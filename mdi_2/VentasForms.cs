using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace mdi
{
    public partial class VentasForms : Form
    {
        public VentasForms()
        {
            InitializeComponent();
            //public  fecha;
            //public  SP_VentasXanos;
    }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                try
                {
                    SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                    conectar.Open();

                    string comboprod = "select distinct(ID_Factura) as Facturar,Producto from Factura";
                    SqlCommand commandprod = new SqlCommand(comboprod, conectar);
                    SqlDataAdapter daprod = new SqlDataAdapter();
                    daprod.SelectCommand = commandprod;
                    DataTable dtprod = new DataTable();
                    daprod.Fill(dtprod);
                    SqlDataReader reader = commandprod.ExecuteReader();
                    

                    //pasando los datos al combobox
                    comboBox1.DataSource = dtprod;
                    comboBox1.ValueMember = "Facturar";
                    comboBox1.DisplayMember = "Producto";

                    if(reader.Read())
                    {
                        dataGridViewVentas.DataSource = dtprod;
                        dataGridViewVentas.Visible = true;
                        conectar.Close();


                    }

                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Numero de factura no existe", ex.Message);
                }

                  

            }
            
            else
            {
                MessageBox.Show("Favor seleccionar un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VentasForms_Load(object sender, EventArgs e)
        {
            ///labuser.text = ventasuser.text;
             //ventas.

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();
            string comboprod = "select Distinct(DATEPART(YY,Fecha)) as Fechas,ID_Factura from Factura";
            SqlCommand commandProd = new SqlCommand(comboprod, conectar);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            ComboFechas.DataSource = dtprod;
            ComboFechas.ValueMember = "ID_Factura";
            ComboFechas.DisplayMember = "Fechas";


        }
        

        private void ComboFechas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
