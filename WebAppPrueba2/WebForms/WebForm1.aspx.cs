using System;

namespace WebAppPrueba2.WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

            protected void Button1_Click(object sender, EventArgs e)
        {
            LabelResultado.Text = "Resutado = " + Convert.ToString(Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text));
        }  
    }
}