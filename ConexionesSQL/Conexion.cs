using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConexionesSQL
{
    class Conexion
    {
        public void MostrarDatos()
        {
            try
            {
                string SQL = "Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True";
                SqlConnection Conectar = new SqlConnection(SQL);
                Conectar.Open();
                MessageBox.Show("Conexion Activa");

            }

            catch(Exception e1)
            {
                MessageBox.Show("Erorr en la conexion en la clase conection", e1.Message);  
            }
        }
    }
}
