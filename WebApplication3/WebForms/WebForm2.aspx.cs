using System;

namespace WebApplication3.WebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {







        }


        protected void Button_Click(object sender, EventArgs e)
        {
            if (RadioSuma.Checked == true)
            {
                LabelResultado.Text = "Resutado = " + Convert.ToString(Convert.ToDouble(TextBoxNum1.Text) + Convert.ToDouble(TextBoxNum2.Text));
            }

            if (RadioResta.Checked == true)
            {
                LabelResultado.Text = "Resutado = " + Convert.ToString(Convert.ToDouble(TextBoxNum1.Text) - Convert.ToDouble(TextBoxNum2.Text));
            }

            if (RadioMulti.Checked == true)
            {
                LabelResultado.Text = "Resutado = " + Convert.ToString(Convert.ToDouble(TextBoxNum1.Text) * Convert.ToDouble(TextBoxNum2.Text));
            }

            if (RadioDivi.Checked == true)
            {
                LabelResultado.Text = "Resutado = " + Convert.ToString(Convert.ToDouble(TextBoxNum1.Text) / Convert.ToDouble(TextBoxNum2.Text));
            }


        }


    }
}