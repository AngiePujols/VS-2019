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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string searchValue = textBox1.Text;
            int rowIndex = -1;
            dataGridViewVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ///if(textBox1.Text=="")
            {
                MessageBox.Show("No puede dejar nada vacio");
            }
            try
            {
                foreach (DataGridViewRow row in dataGridViewVentas.Rows)
                {
                    //if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridViewVentas.ClearSelection();
                        row.Selected = true;
                        dataGridViewVentas.FirstDisplayedScrollingRowIndex = rowIndex;
                        dataGridViewVentas.Focus();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay información que concuerde con ese ID.");
            }
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            CbNoVentas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFechas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CbNoVentas_Click(object sender, EventArgs e)
        {
            if (CbNoVentas.Text != "Seleccionar")
            {
                try
                {
                    SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                    conectar.Open();

                    string comboprod = "select distinct(ID_Factura) as Facturar from Factura";
                    SqlCommand command = new SqlCommand(comboprod, conectar);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //Pasando Datos
                    CbNoVentas.DataSource = dt;
                    CbNoVentas.ValueMember = "Facturar";
                    CbNoVentas.DisplayMember = "Facturar";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Numero de Venta no existe", ex.Message);
                }



            }

            else
            {
                MessageBox.Show("Favor seleccionar un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void ComboFechas_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();
            string comboprod = "select Distinct(DATEPART(YY,Fecha)) as Fechas from Factura";
            SqlCommand commandProd = new SqlCommand(comboprod, conectar);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            ComboFechas.DataSource = dtprod;
            ComboFechas.ValueMember = "Fechas";
            ComboFechas.DisplayMember = "Fechas";

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (CbNoVentas.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un numero de Venta");
            }
            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string numfactura = CbNoVentas.Text;
                string datos = "select * from Factura where ID_Factura=" + numfactura;

                try
                {
                    //conectar.Open();
                    SqlCommand cmdvalidar = new SqlCommand(datos, conectar);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    SqlDataReader reader = cmdvalidar.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridViewVentas.DataSource = dt;
                        dataGridViewVentas.Visible = true;
                        conectar.Close();
                    }

                    else
                    {
                        MessageBox.Show("Numero de Venta no existe");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (CbNoVentas.Text == "Seleccionar")
            {
                MessageBox.Show("Debe digitar el numero de Venta");
            }

            if (CbNoVentas.Text != "Seleccionar")
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();

                string numfactu = CbNoVentas.Text;
               

                string borrar = "delete Factura where ID_Factura = "+ numfactu ;
                SqlCommand sql = new SqlCommand(borrar, conectar);
                sql.ExecuteNonQuery();

                string datos = "select * from Factura where ID_Factura = " + numfactu;
                SqlConnection Conectando1 = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");

                try
                {
                    Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridViewVentas.DataSource = dt;
                    dataGridViewVentas.Visible = true;
                    Conectando1.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

            

        }

        private void btVentas_Click(object sender, EventArgs e)
        {

            Venta venta = new Venta();
            venta.fecha = ComboFechas.Text;
            venta.Show();
            
        }

        private void CbNoVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbNo_Click(object sender, EventArgs e)
        {

        }
    }
}