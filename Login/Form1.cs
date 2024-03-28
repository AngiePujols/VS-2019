using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ImagenOjo2.Visible = false;
            //ImagenPechu.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {


        }

        private void Imagenlogin_Click(object sender, EventArgs e)
        {
            string Usuario, Contraseña;
            Usuario = "ElPechu";
            Contraseña = "elpechu12345";

            if (textBoxUsuario.Text != Usuario || textBoxContraeña.Text != Contraseña)
            {
                DialogResult Resultado = MessageBox.Show("El usuario o contraseña que has introducido no es La cuenta o contraseña que has introducido no es válida. Introduce una cuenta diferente . Introduce una cuenta diferente ", "Cuenta No Válida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (Resultado == DialogResult.Retry)
                {
                    textBoxContraeña.Text = "";
                    textBoxUsuario.Text = "";
                }
                if (Resultado == DialogResult.Cancel)
                {
                    Close();
                }
            }


            else
            {
                labelCompañia.ForeColor = Color.Black;
                labelCompañia.Text = Usuario;
                labellogin.Visible = false;
                labelUsuario.Visible = false;
                labelContraseña.Visible = false;
                textBoxContraeña.Visible = false;
                textBoxUsuario.Visible = false;
                imagenOjo.Visible = false;
                ImagenOjo2.Visible = false;
                Imagenlogin.Visible = false;
                //ImagenPechu.Visible = true;
            }

        }

        private void ImagenCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxContraeña_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagenOjo_Click(object sender, EventArgs e)
        {
            imagenOjo.Visible = false;
            ImagenOjo2.Visible = true;
            textBoxContraeña.UseSystemPasswordChar = false;
        }

        private void ImagenOjo2_Click(object sender, EventArgs e)
        {
            if (ImagenOjo2.Visible == true)
            {
                ImagenOjo2.Visible = false;
                imagenOjo.Visible = true;
                textBoxContraeña.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 miform = new Form2(textBoxUsuario.Text);
            miform.Show();
            this.Hide();

        }

        private void ImagenPechu_Click(object sender, EventArgs e)
        {
            //ImagenPechu.Image = Login.Properties.Resources.IMG_2729(1).jpg;
        }
    }
}

