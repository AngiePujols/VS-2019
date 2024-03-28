using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fly2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
          
        }

    

        private void Btnclesar_Clicked(object sender, EventArgs e)
        {
            labelres.Text = "";
            num1.Text = "";
            num2.Text = "";

        }

        private void Btndivi_Clicked(object sender, EventArgs e)
        {
            double Resultado = double.Parse(num1.Text) / double.Parse(num2.Text);
            labelres.Text = Resultado.ToString();
        }

        private void Btnmulti_Clicked(object sender, EventArgs e)
        {
           double Resultado = double.Parse(num1.Text) * double.Parse(num2.Text);
            labelres.Text = Resultado.ToString();
            

        }

        private void Btnresta_Clicked(object sender, EventArgs e)
        {
            double Resultado = double.Parse(num1.Text) - double.Parse(num2.Text);
            labelres.Text = Resultado.ToString();
        }

        private void Btnsumar_Clicked(object sender, EventArgs e)
        {
            double Resultado = double.Parse(num1.Text) + double.Parse(num2.Text);
            labelres.Text = Resultado.ToString();
        }
    }
}