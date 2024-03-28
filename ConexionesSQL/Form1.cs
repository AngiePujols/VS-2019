using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ConexionesSQL
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
            
        
            string datos = "select * from Departamentos";
        
            try
            {
                conectar.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGVClientes.DataSource = dt;
                conectar.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.MostrarDatos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite un Codigo");
            }
            else
            {
                string SQL = "Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True";
                SqlConnection Conectar = new SqlConnection(SQL);
                Conectar.Open();
                String ID = textBox1.Text;
                //string Departamento = textBox2.Text;
                //string Descripcion = textBox3.Text;
                string cadena = "select ID_Departamentos,Departamentos,Descripcion from Departamentos where ID_Departamentos =" + ID;
                SqlCommand command = new SqlCommand(cadena, Conectar);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["Departamentos"].ToString();
                    textBox3.Text = reader["Descripcion"].ToString();
                }

                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
                conectar.Open();
                string id = textBox1.Text;
                string nombre = textBox2.Text;
                string descrip = textBox3.Text;
                string query = "Insert into Departamentos(ID_Departamentos, Departamentos, Descripcion) Values('" + id + "','" + nombre + "','" + descrip + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
                dataGVClientes.Refresh();
                lbcontrol.Visible = false;
                conectar.Close();
                string datos = "select * from Departamentos";
                SqlConnection Conectando1 = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");

                try
                {
                    Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGVClientes.DataSource = dt;
                    Conectando1.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                lbcontrol.Text = "Debe llenar todos los campos";
                lbcontrol.Visible = true;
            }

            
        

    }

    private void button4_Click(object sender, EventArgs e)
        {
        
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
            conectar.Open();
            string id = textBox1.Text;
            string nombre_Departamento = textBox2.Text;
            string descrip = textBox3.Text;
            string actualizar = "update Departamentos set Departamentos = '" + nombre_Departamento + "', Descripcion = '" + descrip + "' where ID_Departamentos = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(actualizar, conectar);
            int controlador;
            controlador = cmd.ExecuteNonQuery();
            if(controlador == 1)
            {
                MessageBox.Show("Fueron modificados los Datos");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                button4.Enabled = false;

            }
            
            else
            {
                MessageBox.Show("No se pudo modificar los Datos");
                conectar.Close();
            }
            string datos = "select * from Departamentos";
            SqlConnection Conectando = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
           
            try
            {
                Conectando.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGVClientes.DataSource = dt;
                Conectando.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text != "")
            {
                button4.Enabled = true;
            }

            else
            {
                button4.Enabled = false;
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text != "")
            {
                button4.Enabled = true;
            }

            else
            {
                button4.Enabled = false;
            }  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                lbcontrol.Text = "Debe llenar el Campo ID";
                lbcontrol.Visible = true;
            }
            if (textBox1.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
                conectar.Open();
                string id = textBox1.Text;
                string nombre_Departamento = textBox2.Text;
                string descrip = textBox3.Text;
                string eliminar = "DELETE FROM Departamentos WHERE ID_Departamentos = '" + id + "'";
                SqlCommand cmd = new SqlCommand(eliminar, conectar);
                int conteo;
                conteo = cmd.ExecuteNonQuery();
                if (conteo == 1)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Fueron eliminados los Datos");


                }

                else
                {
                    MessageBox.Show("No Existe este Departamento");
                }

                string datos = "select * from Departamentos";
                SqlConnection Conectando = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");

                try
                {
                    Conectando.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGVClientes.DataSource = dt;
                    Conectando.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("El archivo selecionado no es un tipo de imagen", ex.Message);
            }
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Debe poner una foto");
            }

            else
            {

                try
                {
                    SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
                    //conectar.Open();
                    string id = textBox1.Text;
                    string nombredepar = textBox2.Text;
                    string descrip = textBox3.Text;

                    string cadena = "Insert into Departamentos(ID_Departamentos, Departamentos, Descripcion, Imagen) Values(@id , @nombre, @descrip, @imagen)";
                    SqlCommand cmd = new SqlCommand(cadena, conectar);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@descrip", System.Data.SqlDbType.NVarChar);

                    //Ensamble
                    cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);

                    cmd.Parameters["@id"].Value = int.Parse(textBox1.Text);
                    cmd.Parameters["@nombre"].Value = textBox2.Text;
                    cmd.Parameters["@descrip"].Value = textBox3.Text;


                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                    conectar.Open();
                    cmd.ExecuteNonQuery();
                    conectar.Close();

                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                SqlConnection Conectando = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
                Conectando.Open();
                string datos = "select * from Departamentos";
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGVClientes.DataSource = dt;
                    Conectando.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            

                try
                {
                    SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QC54183\\SQLEXPRESS01;Initial Catalog=RRHH2;Integrated Security=True");
                    conectar.Open();

                    string id = textBox1.Text;
                    string buscar = "select Departamentos, Descripcion, Imagen from Departamentos where ID_Departamentos = " + id;

                    SqlCommand command = new SqlCommand(buscar, conectar);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        MemoryStream memory = new MemoryStream((byte[])reader["Imagen"]);
                        Bitmap bm = new Bitmap(memory);
                        pictureBox1.Image = bm;
                        textBox2.Text = reader["Departamentos"].ToString();
                        textBox3.Text = reader["Descripcion"].ToString();


                    }
                }

                catch (Exception e1)
                {
                    MessageBox.Show("El codigo no existe", e1.Message);

                }
            
        }
    }
}
