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
    public partial class Tarjeta3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //General: Cargando datos en el comboidventas
                Class1 sqlcon = new Class1();
                SqlCommand cmd = new SqlCommand("select Num_cuenta from Cuenta", sqlcon.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                DropCuenta.DataSource = ds;
                DropCuenta.DataTextField = "Num_cuenta";
                DropCuenta.DataValueField = "Num_cuenta";
                DropCuenta.DataBind();
                DropCuenta.Items.Insert(0, new ListItem("Seleccione una cuenta", "0"));


            }
            catch (Exception e1)
            {
                LabelMsj.Text = "Error de conexión";
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (DropCuenta.SelectedItem.Text == "Seleccione una cuenta")
            {
                LabelMsj.Text = "Favor elegir una cuenta";
                DropCuenta.Focus();

            }
            else
            {
                Labelnumero.Text = DropCuenta.SelectedItem.Text;
               
                Session["cuenta"] = Labelnumero.Text;
            }
        }

        protected void DropCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
    


        }
    }
}