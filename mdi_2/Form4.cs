using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace mdi
{
    public partial class Form4 : Form
    {
        public object usuario { get; internal set; }

        public Form4()
        {
            InitializeComponent();
            

        }

   

        private void Form4_Load(object sender, EventArgs e)
        {
            LabelDate.Text = DateTime.Now.ToString();
            textBoxNo.Focus();
            LabelUser1.Text = Convert.ToString(usuario);
            clientesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
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

        
       


        private void facturarButton_Click(object sender, EventArgs e)
        {
           
            if (textBoxNo.Text == "")
            {
                MessageBox.Show("Debe digitar el numero de Factura");
            }
            else
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();
                string numfactura = textBoxNo.Text;
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
                        Factura facturar = new Factura();
                        facturar.numero_factura = Convert.ToInt32(textBoxNo.Text);
                        facturar.Show();
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

            if (textBoxNo.Text == "")
            {
                MessageBox.Show("Debe digitar el numero de Factura");
            }
            else
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


                if (reader.Read())
                {
                    precio1TextBox.Text = reader["Precio_Unitario"].ToString();

                    //MessageBox.Show("Se han encontrado Datos.");
                }
                if(clientesComboBox.SelectedItem != null)
                {
                    clientesComboBox.Enabled = false;
                }
                textBox7.Focus();
            }
        }

        private void agregarButton2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();

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
                string Fecha = LabelDate.Text;
                string empleado = LabelUser1.Text;
               
                string quetyinsert = "insert into Factura(ID_Factura,Cliente,Empleado,Producto,Precio,Cantidad,Fecha,Total) Values('" + id+ "','" + Cliente + "','" + empleado + "','" + producto + "','" + precio + "','" + cantidad + "','" + Fecha + "','" + total.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(quetyinsert, conectar);
                sqlCommand.ExecuteNonQuery();
                textBox7.Text = "";
                precio1TextBox.Text = "";
                label4.Visible = false;
                label8.Visible = false;
                precio1TextBox.Visible = false;
                textBox7.Visible = false;
                agregarButton2.Visible = false;
                btEliminar.Enabled = true;
                label6.Visible = true;
                comboBoxEliminar.Visible = true;


            }

            catch(Exception e1)
            {
                MessageBox.Show("Error al insertar los datos", e1.Message);
            }

            double numero = Convert.ToInt32(textBoxNo.Text);
            double numfactura = numero - 1;  
            string datos = "select * from Factura where ID_Factura="+numero;

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

            if(textBoxNo.Text=="")
            {
                MessageBox.Show("Debe digitar el numero de Factura");
            }

            if (comboBoxEliminar.Text != "Seleccionar")
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
                conectar.Open();

                string numfactu = textBoxNo.Text;
                string nom_product = comboBoxEliminar.Text;

                string borrar = "delete Factura where ID_Factura = '" + numfactu + "' and Producto = '" + nom_product + "'";
                SqlCommand sql = new SqlCommand(borrar, conectar);
                sql.ExecuteNonQuery();

                string datos = "select * from Factura where ID_Factura = "+ numfactu ;
                SqlConnection Conectando1 = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");

                try
                {
                    //Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
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


        private void textBoxNo_Enter(object sender, EventArgs e)
        {
           
        }

      
        private void comboBoxProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void comboBoxProductos_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=Pagina;Integrated Security=True");
            conectar.Open();

            //int indice = clientesComboBox.SelectedIndex;

            string ID = comboBoxProductos.SelectedValue.ToString();
            string cadena = "select ID_Productos,Precio_Unitario from Productos where ID_Productos= " + ID;
            string id1 = comboBoxProductos.Text;

            SqlCommand command = new SqlCommand(cadena, conectar);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                precio1TextBox.Text = reader["Precio_Unitario"].ToString();

                //MessageBox.Show("Se han encontrado Datos.");
            }
        }

        private void textBoxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelUser1_Click(object sender, EventArgs e)
        {

        }
    }
}





