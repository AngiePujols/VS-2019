using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class Venta : Form
    {
        public string fecha;
        public Venta()
        {
            InitializeComponent();
        }

      
        private void Venta_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSet1.SP_VentasXanos' table. You can move, or remove it, as needed.
            this.SP_VentasXanosTableAdapter.Fill(this.DataSet1.SP_VentasXanos,fecha);
            
            this.reportViewer1.RefreshReport();




        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
