using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Claveath.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedItem.Text == "Elegir una Cuenta")
            {
                Label2.Text = "favor elegir una cuenta";
                DropDownList1.Focus();

            }
            else
            {
                Response.Redirect("Claveath.aspx");
                Session["cuneta"] = Label3.Text;

            }
        }
    }
}