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
    public partial class Factura : Form
    {
        public int numero_factura;
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.SP_Factura' table. You can move, or remove it, as needed.
            this.SP_FacturaTableAdapter.Fill(this.DataSet1.SP_Factura,numero_factura);
            // TODO: This line of code loads data into the 'DataSet1.SP_Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.DataSet1.Factura);
            // TODO: This line of code loads data into the 'DataSet1.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.DataSet1.Factura);
            // TODO: This line of code loads data into the 'DataSet1.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.DataSet1.Factura);
            // TODO: This line of code loads data into the 'DataSet1.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.DataSet1.Factura);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
