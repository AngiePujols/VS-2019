using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection conectar()
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP - QC54183\\SQLEXPRESS01; Initial Catalog = RRHH_4; Integrated Security = True");
            conn.Open();
            return conn;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "" || TextBox2.Text == "")
            {
                
            }

           else
            {
                conexion = 
            }

        }

        protected void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}