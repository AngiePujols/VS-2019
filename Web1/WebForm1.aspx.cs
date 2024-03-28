using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication3;

namespace Web1
{
   
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label2.Text = "No puede dejar ningun campo vacio";
            }

            else
            {



                Class1 sqlcon = new Class1();
                SqlCommand cmd = new SqlCommand("SP_login", sqlcon.conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Clave", TextBox2.Text);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 1)
                {
                    Session["name"] = TextBox1.Text;

                    Response.Redirect("WebForm2.apx");
                }

                if (TextBox1.Text == "" || TextBox2.Text == "")
                {
                    Label2.Text = "No encontro ningun usuario";
                }

            }
        }
    }
}