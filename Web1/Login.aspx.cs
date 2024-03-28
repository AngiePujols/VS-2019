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
    public partial class WebForm5 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

              //ScriptManager.RegisterStartupScript(this, this.GetType(), 
//"alert",
//"alert('Contraseña esta en default, necesitamos que la cambie');window.location ='Password.aspx';", 
//true);
            //Response.Write("<script>alert('Contraseña esta en default, necesitamos que la cambie');window.location =('WebForm6.aspx');</script>");

        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {


            Class1 conn = new Class1();
            SqlCommand user = new SqlCommand("SP_SP_Login22", conn.conectar());
            user.CommandType = CommandType.StoredProcedure;
            string usuario = TextBoxEmail.Text;
            string clave = TextBoxPass.Text;
            user.Parameters.AddWithValue("@Usuario", usuario);
            user.Parameters.AddWithValue("@Clave", clave);
            
            int num = Convert.ToInt32(user.ExecuteScalar());


            if (num == 0)
            {

               Response.Write("<script>alert('Usuario o Clave Incorrecto')</script>") ; 

            }
            else
            {
                Response.Redirect("WebForm4.aspx");

            }
        }
    }
 }
