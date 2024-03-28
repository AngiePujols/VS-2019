using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cajero
{
    public partial class TipoDeTransaccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAceptar1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Balance.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Retiro.aspx");
        }

        protected void ButtonAceptar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deposito.aspx");
        }
    }
}