using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql.Models;
using Xamarin.Forms;

namespace Sql
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnregistrar_Clicked(object sender, EventArgs e)
        {
            {
                if (validarDatos())
                {
                    Alumno alum = new Alumno
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Edad = int.Parse(txtEdad.Text),
                        Email = txtEmail.Text,
                    };
                    await App.SQLiTeDB.SaveAlunmoAsync(alum);
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtEdad.Text = "";
                    txtEmail.Text = "";
                    await DisplayAlert("registro", "se guardo de manera exitosa", "ok");
                }
                else
                {
                    await DisplayAlert("advertencia", "incresar todos los datod", "ok");
                }
            }
        }
        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                respuesta = false;
            }
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                respuesta = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
