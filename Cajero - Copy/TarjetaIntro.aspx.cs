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