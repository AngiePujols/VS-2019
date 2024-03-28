using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace mdi
{
    public partial class Form4 : Form
    {
      

        private List<TextBox> precioTextboxs = new List<TextBox>();
        private List<int> precios = new List<int>();
        private List<TextBox> cantidadTextboxs = new List<TextBox>();

        private List<Label> productoLabels = new List<Label>();
        private List<Label> precioLabels = new List<Label>();
        private List<Label> cantidadLabels = new List<Label>();

        private int indiceFactura = 0;
        private int total = 0;

        public Form4()
        {
            InitializeComponent();
            configurarLista();
            totalLabel.Text = total.ToString();
        }

        private void configurarLista()
        {
            precioTextboxs.Add(precio1TextBox);
            precioTextboxs.Add(precio2TextBox);
            precioTextboxs.Add(precio3TextBox);
            precioTextboxs.Add(precio4TextBox);
            precioTextboxs.Add(precio5TextBox);

            precios.Add(800);
            precios.Add(255);
            precios.Add(665);
            precios.Add(500);
            precios.Add(175);

            cantidadTextboxs.Add(textBox7);
            cantidadTextboxs.Add(textBox6);
            cantidadTextboxs.Add(textBox3);
            cantidadTextboxs.Add(textBox2);
            cantidadTextboxs.Add(textBox4);

            productoLabels.Add(producto1Label);
            productoLabels.Add(producto2Label);
            productoLabels.Add(producto3Label);
            productoLabels.Add(producto4Label);
            productoLabels.Add(producto5Label);

            precioLabels.Add(precio1Label);
            precioLabels.Add(precio2Label);
            precioLabels.Add(precio3Label);
            precioLabels.Add(precio4Label);
            precioLabels.Add(precio5Label);

            cantidadLabels.Add(cantidad1Label);
            cantidadLabels.Add(cantidad2Label);
            cantidadLabels.Add(cantidad3Label);
            cantidadLabels.Add(cantidad4Label);
            cantidadLabels.Add(cantidad5Label);
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fechaLabel.Text = DateTime.Now.ToString();
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();

            string combolist = "select ID_Cliente,Nombre+' '+Apellido as Nombres from Cliente";
            SqlCommand command = new SqlCommand(combolist, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Pasando Datos
            clientesComboBox.DataSource = dt;
            clientesComboBox.ValueMember = "ID_Cliente";
            clientesComboBox.DisplayMember = "Nombres";



            string comboprod = "select ID_Productos,Producto_Nombre from Productos";
            SqlCommand commandProd = new SqlCommand(comboprod, conectar);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            comboBoxProductos.DataSource = dtprod;
            comboBoxProductos.ValueMember = "ID_Productos";
            comboBoxProductos.DisplayMember = "Producto_Nombre";

            SqlConnection conectar1 = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar1.Open();

            //int indice = clientesComboBox.SelectedIndex;

           
            string cadena1 = "select max(ID_Factura) + 1 as numfact from Factura";
            string id1 = comboBoxProductos.Text;

            SqlCommand command1 = new SqlCommand(cadena1, conectar1);
            SqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.Read())
            {
                textBoxNo.Text = reader1["numfact"].ToString();

            }
          
        }

        private void clientesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreClienteLabel.Text = clientesComboBox.Text;
        }

        private void productosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productosListBox.SelectedIndex % 2 == 0)
            {
                precioTextboxs[productosListBox.SelectedIndex / 2].Text = precios[productosListBox.SelectedIndex / 2].ToString();
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {

            if (clientesComboBox.Text == "")
            {
                MessageBox.Show("Favor seleccionar el cliente para poder ingresar a esta opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productosListBox.SelectedIndex % 2 == 0)
            {
                int indice = productosListBox.SelectedIndex / 2;
                if (cantidadTextboxs[indice].Text == "")
                {
                    MessageBox.Show("Favor digitar la cantidad para poder ingresar a esta opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                productoLabels[indiceFactura].Text = productosListBox.Items[indice * 2].ToString();
                cantidadLabels[indiceFactura].Text = cantidadTextboxs[indice].Text;
                int totalProducto = Convert.ToInt32(precioTextboxs[indice].Text) * Convert.ToInt32(cantidadTextboxs[indice].Text);
                precioLabels[indiceFactura].Text = totalProducto.ToString();
                int Totalfinal = Convert.ToInt32(precioTextboxs[indice].Text) * Convert.ToInt32(cantidadTextboxs[indice].Text);
                indiceFactura++;

                totalLabel.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Favor seleccionar el producto para poder ingresar a esta opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void facturarButton_Click(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(totalLabel.Text) > 0)
            //{
            //  MessageBox.Show("La facturación se ha realizado con exito.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //  MessageBox.Show("Favor seleccione lo que desea facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            Factura facturar = new Factura();
            facturar.numero_factura = Convert.ToInt32(textBoxNo.Text);
            facturar.Show();

        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            clientesComboBox.SelectedIndex = -1;
            comboBoxProductos.SelectedIndex = -1;

            for (int i = 0; i < precioTextboxs.Count; i++)
            {
                precioTextboxs[i].Text = "";
                cantidadTextboxs[i].Text = "";
                productoLabels[i].Text = "";
                cantidadLabels[i].Text = "";
                precioLabels[i].Text = "";
            }
            indiceFactura = 0;
            total = 0;
            totalLabel.Text = total.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            precio1TextBox.Visible = true;
            textBox7.Visible = true;
            label8.Visible = true;
            label4.Visible = true;
            agregarButton2.Visible = true;

            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();

            //int indice = clientesComboBox.SelectedIndex;

            string ID = comboBoxProductos.SelectedValue.ToString();
            string cadena = "select ID_Productos,Precio_Unitario from Productos where ID_Productos= " + ID;
            string id1 = comboBoxProductos.Text;

            SqlCommand command = new SqlCommand(cadena, conectar);
            SqlDataReader reader = command.ExecuteReader();
            labelPrueba.Text = id1;
            lbPrueba2.Text = clientesComboBox.Text;

            if (reader.Read())
            {
                precio1TextBox.Text = reader["Precio_Unitario"].ToString();

                //MessageBox.Show("Se han encontrado Datos.");
            }

            textBox7.Focus();


        }

        private void agregarButton2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();
            if (textBox7.Text != "" && precio1TextBox.Text != "" && clientesComboBox.Text != "" && comboBoxProductos.Text != "")
            {
                lbControl.Text = "Todo esta Bien";
                lbControl.Visible = true;


            }

            else
            {
                lbControl.Text = "Debe llenar los Datos";
                lbControl.Visible = true;
            }

            try 
            {
               
                
                double precio = Convert.ToDouble(precio1TextBox.Text);
                double cantidad = Convert.ToDouble(textBox7.Text);
                double total = precio * cantidad;
                ////////////


                string id = textBoxNo.Text;
                string Cliente = clientesComboBox.Text;
                string producto = comboBoxProductos.Text;
                string precio1 = precio1TextBox.Text;
                string cantidad1 = textBox7.Text;
                string Fecha = fechaLabel.Text;
               
                string quetyinsert = "insert into Factura(ID_Factura,Cliente,Producto,Precio,Cantidad,Fecha,Total) Values('"+id+ "','" + Cliente + "','" + producto + "','" + precio + "','" + cantidad + "','" + Fecha + "','" + total.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(quetyinsert, conectar);
                sqlCommand.ExecuteNonQuery();
                textBox7.Text = "";
                precio1TextBox.Text = "";
                label4.Visible = false;
                label8.Visible = false;
                btBuscar.Visible = false;
                
            }

            catch(Exception e1)
            {
                MessageBox.Show("Error al insertar los datos", e1.Message);
            }
            
            string numfactura = textBoxNo.Text;
            string datos = "select * from Factura ";

            try
            {
                //conectar.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dGviewFactura.DataSource = dt;
                dGviewFactura.Visible = true;
                conectar.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK);
                e.Handled = true;
                return;
                }
        }

        private void groupBoxFactura_Enter(object sender, EventArgs e)
        {

        }

        private void precio1Label_Click(object sender, EventArgs e)
        {

        }

        private void cantidad1Label_Click(object sender, EventArgs e)
        {

        }

        private void producto1Label_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar2_Click(object sender, EventArgs e)
        {
            if (lbnumfac.Visible == false && textbNF.Visible == false && BtEnviar.Visible == false)
            {
                lbnumfac.Visible = true;
                textbNF.Visible = true;
                BtEnviar.Visible = true;
            }

            else 
            {
                lbnumfac.Visible = false;
                textbNF.Visible = false;
                BtEnviar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btBuscar.Text == "")
            {
                MessageBox.Show("Debe digitar el numero de Factura");
            }
            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string numfactura = textbNF.Text; 
                string datos = "select * from Factura where ID_Factura=" + numfactura;

                try
                {
                    //conectar.Open();
                    SqlCommand cmdvalidar = new SqlCommand(datos, conectar);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    SqlDataReader reader = cmdvalidar.ExecuteReader();

                    if(reader.Read())
                    {
                        dGviewFactura.DataSource = dt;
                        dGviewFactura.Visible = true;
                        conectar.Close();
                    }

                    else
                    {
                        MessageBox.Show("Numero de factura no existe");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void textbNF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbnumfac_Click(object sender, EventArgs e)
        {

        }

        private void textbNF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void btBuscar2_MouseHover(object sender, EventArgs e)
        {
            if(lbnumfac.Visible != true || textbNF.Visible != true || BtEnviar.Visible != true)
            {
                btBuscar2.Text = "Mostrar";
            }

            else
            {
                btBuscar2.Text = "Buscar";
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxEliminar.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();

                string numfactu = textBoxNo.Text;
                string nom_product = comboBoxEliminar.Text;

                string borrar = "delete Factura where ID_Factura = '" + numfactu + "' and Producto = '" + nom_product + "'";
                SqlCommand sql = new SqlCommand(borrar, conectar);
                sql.ExecuteNonQuery();

                string datos = "select * from Factura where ID_Factura = " + numfactu;
                SqlConnection Conectando1 = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");

                try
                {
                    conectar.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dGviewFactura.DataSource = dt;
                    dGviewFactura.Visible = true;
                    Conectando1.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

            else
            {
                MessageBox.Show("Seleccione un Producto");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();
            string comboprod = "select ID_Productos,Producto_Nombre from Productos";
            SqlCommand commandProd = new SqlCommand(comboprod, conectar);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            comboBoxEliminar.DataSource = dtprod;
            comboBoxEliminar.ValueMember = "ID_Productos";
            comboBoxEliminar.DisplayMember = "Producto_Nombre";

        }

        private void comboBoxProductos_Click(object sender, EventArgs e)
        {

        }
    }
}





