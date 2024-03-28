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


namespace Web1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
          
            Class1 conn = new Class1();
            SqlCommand cmd = new SqlCommand("SP_Registrar_Cliente", conn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;



            //Asignando valores a los parametros
            cmd.Parameters.AddWithValue("@Cliente_Nombre", TextBoxNo.Text);
            cmd.Parameters.AddWithValue("@Cliente_Apellido", TextBoxAp.Text);
            cmd.Parameters.AddWithValue("@Cedula", TextBoxCedu.Text);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", TextBoxFechNa.Text);
            cmd.Parameters.AddWithValue("@Telefono", TextBoxTel.Text);
            cmd.Parameters.AddWithValue("@Direccion", TextBoxDir.Text);
            cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);

            SqlCommand user = new SqlCommand("SP_SP_Registrar_Usuario", conn.conectar());
            user.CommandType = CommandType.StoredProcedure;

            user.Parameters.AddWithValue("@Usuario", TextBoxEmail.Text);
            user.Parameters.AddWithValue("@Clave", "12345");

            int Ejecucioncliente = cmd.ExecuteNonQuery();
            int Ejecucionuser = user.ExecuteNonQuery();


            if (Ejecucioncliente == 0 & Ejecucionuser == 0)
            {
                


            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
    }
}