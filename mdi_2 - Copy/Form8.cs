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
            string searchValue = textBox1.Text;
            int rowIndex = -1;
            dataGridViewVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if(textBox1.Text=="")
            {
                MessageBox.Show("No puede dejar nada vacio");
            }
            try
            {
                foreach (DataGridViewRow row in dataGridViewVentas.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
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
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");


            string datos = "select * from Ventas";

            try
            {
                conectar.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridViewVentas.DataSource = dt;
                conectar.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}