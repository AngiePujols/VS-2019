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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelUser.Text = Session["name"].ToString();
        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (TextBoxcontrasenaC.Text == TextBoxContrasena.Text)
            {

                Info.Visible = false;

                //Conectando con la BD
                Class1 sqlcon = new Class1();
                SqlCommand cmd = new SqlCommand("SP_Cambiar_contrasena", sqlcon.conectar());
                cmd.CommandType = CommandType.StoredProcedure;



                //Asignando valores a los parametros
                cmd.Parameters.AddWithValue("@User", LabelUser.Text);
                cmd.Parameters.AddWithValue("@Contrasena", TextBoxContrasena.Text);


                //Poniendo invisibles mis herramientas de confirmación




                int Ejecucioncontra = cmd.ExecuteNonQuery();



                if (Ejecucioncontra != 0)
                {
                    Response.Redirect("PaginaPrincipal.aspx");

                }

            }
            else
            {
                Info.Visible = true;
            }

        }
    }
}