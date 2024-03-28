using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1
{
    public partial class Claveath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxclave.Focus();
        }

        protected void TextBoxclave_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}