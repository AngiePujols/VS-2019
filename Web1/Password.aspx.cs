using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebApplication3;
using System.Web.UI;
using System.Web;
namespace Web1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonA2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH_4;Integrated Security=True");
            conn.Open();
            string usuario = TextBoxE2.Text;
            string clave = TextBoxP2.Text;
            string actualizar = "update Usuario set Usuario = '" + usuario + "', Clave = '" + clave + "'";
            SqlCommand cmd = new SqlCommand(actualizar, conn);
            int controlador;
            controlador = cmd.ExecuteNonQuery();
            if (controlador == 1)
            {

                Response.Write("<script>alert('No se pudo modificar los Datos')</script>");

            }

            else
            {
                
                Response.Write("<script>alert('Los Datos Fueron Actualizados')</script>");
                conn.Close();
            }
           

        }
    }
}