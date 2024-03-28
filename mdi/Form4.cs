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
        private int total1 = 0;

        public Form4()
        {
            InitializeComponent();
            configurarLista();
            totalLabel.Text = total1.ToString();
        }

        private void configurarLista()
        {
            precioTextboxs.Add(precio1TextBox);




            cantidadTextboxs.Add(textBox7);


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


        private void agregarButton_Click(object sender, EventArgs e)
        {

            if (clientesComboBox.Text == "")
            {
                MessageBox.Show("Favor seleccionar el cliente para poder ingresar a esta opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxProductos.SelectedIndex == -1)
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
                    
                    

                    productoLabels[indiceFactura].Text = precio1.ToString();
                    cantidadLabels[indiceFactura].Text = cantidad1.ToString();
                    precioLabels[indiceFactura].Text = total.ToString();
                    total1 +=;
                    indiceFactura++;

                    totalLabel.Text = total1.ToString();


                    string quetyinsert = "insert into Factura(ID_Factura,Cliente,Producto,Precio,Cantidad,Fecha,Total) Values('" + id + "','" + Cliente + "','" + producto + "','" + precio + "','" + cantidad + "','" + Fecha + "','" + total.ToString() + "')";
                    SqlCommand sqlCommand = new SqlCommand(quetyinsert, conectar);
                    sqlCommand.ExecuteNonQuery();
                    textBox7.Text = "";
                    precio1TextBox.Text = "";
                    label4.Visible = false;
                    label8.Visible = false;
                    btBuscar.Visible = false;

                }

                catch (Exception e1)
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

            }

            private void facturarButton_Click(object sender, EventArgs e)
            {
                if (Convert.ToInt32(totalLabel.Text) > 0)
                {
                    MessageBox.Show("La facturación se ha realizado con exito.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Favor seleccione lo que desea facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                agregarButton.Visible = true;

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


            private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK);
                    e.Handled = true;
                    return;
                }
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

                        if (reader.Read())
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
                if (lbnumfac.Visible != true || textbNF.Visible != true || BtEnviar.Visible != true)
                {
                    btBuscar2.Text = "Mostrar";
                }

                else
                {
                    btBuscar2.Text = "Buscar";
                }

            }
        }
    } 






