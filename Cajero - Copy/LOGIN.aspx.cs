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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {

            

            //Confirmador de si la contraseña es correcta y el usuario a través de la BD
            if (TextBoxUser.Text != "" & TextBoxContraseña.Text != "")
            {

                //Conectando con la BD
                Class1 sqlcon = new Class1();
                SqlCommand cmd = new SqlCommand("SP_login", sqlcon.conectar());
                cmd.CommandType = CommandType.StoredProcedure;


                string user = TextBoxUser.Text;
                string clave = TextBoxContraseña.Text;

                //Asignando valores a los parametros
                cmd.Parameters.AddWithValue("@Usuario", user);
                cmd.Parameters.AddWithValue("@Clave", clave);

                //Declarando y asignando variables
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                Session["name"] = TextBoxUser.Text;

                if (result == 0)
                {
                  
                    Info.Visible = true;
                    Info.Text = "*La contraseña o el usuario son incorrectos o no existen, favor registrarse sino todavía no lo ha realizado*";
                }
                else if (TextBoxContraseña.Text == "12345" & result == 1)
                {

                    Response.Redirect("cambiarContraseña.aspx");



                }
                else if (result == 1)
                {
                    Response.Redirect("PaginaPrincipal.aspx");

                }

           
            }
        }
    }
}