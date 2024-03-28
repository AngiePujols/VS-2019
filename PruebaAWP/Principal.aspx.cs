using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaAWP
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TbNum1.Text == "" || TbNum2.Text == "")
            {
                Labelmsj.Text = "Debe llenar todos los campos.";
                Labelmsj.Visible = true;
            }

            else
            {
                int num1, num2, result;
                num1 = Convert.ToInt32(TbNum1.Text);
                num2 = Convert.ToInt32(TbNum2.Text);
                result = num1 + num2;

                TbResultado.Text = result.ToString();
                Labelmsj.Visible = false;
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TbUser.Text == "" || TbPassword.Text == "")
            {

                Labelmess.Text = "Debe llenar todos los Campos";
                Labelmess.ForeColor = System.Drawing.Color.Red;

            }

            if (TbUser.Text == "Angie Pujols" && TbPassword.Text == "Angie12")

            {
                Labelmess.Text = "Bienvenido al Sistema";
                Labelmess.ForeColor = System.Drawing.Color.LightGreen;
                Response.Redirect("PaginaSecundaria");  
            }
            else 
            {
                Labelmess.Text = "Contraseña o usuario incorrecto";
            }

        }
    }
}