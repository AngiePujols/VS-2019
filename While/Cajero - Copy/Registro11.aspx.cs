using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Cajero
{
    public partial class Registro11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {
            //Conectando con la BD
            Class1 sqlcon = new Class1();
            SqlCommand cmd = new SqlCommand("SP_Registrar_Cliente", sqlcon.conectar());
            cmd.CommandType = CommandType.StoredProcedure;



            //Asignando valores a los parametros
            cmd.Parameters.AddWithValue("@Cliente_Nombre", TextBoxNombre.Text);
            cmd.Parameters.AddWithValue("@Cliente_Apellido", TextBoxApellido.Text);
            cmd.Parameters.AddWithValue("@Cedula", TextBoxCedula.Text);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", TextBoxFechaN.Text);
            cmd.Parameters.AddWithValue("@Telefono", TextBoxTelefono.Text);
            cmd.Parameters.AddWithValue("@Direccion", TextBoxDireccion.Text);
            cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);

            SqlCommand user = new SqlCommand("SP_SP_Registrar_Usuario", sqlcon.conectar());
            user.CommandType = CommandType.StoredProcedure;

            user.Parameters.AddWithValue("@Usuario", TextBoxEmail.Text);
            user.Parameters.AddWithValue("@Clave", "12345");


            //Poniendo invisibles mis herramientas de confirmación




            int Ejecucioncliente = cmd.ExecuteNonQuery();
            int Ejecucionuser = user.ExecuteNonQuery();


            if (Ejecucioncliente != 0 & Ejecucionuser != 0)
            {
               
                Response.Redirect("Login.aspx");

            }
            
        }
    }
}