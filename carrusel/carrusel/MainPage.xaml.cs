using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace carrusel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            premios = new ObservableCollection<premio>
{
new premio{Image = "agla.jpg",Name="Aglaonema"},
new premio{Image = "agla2.jpg",Name="Kalanchoe"},
new premio{Image = "agla3.jpg",Name="Orquídeas"},
new premio{Image = "agla4.jpg",Name="Girasoles"},
new premio{Image = "agla1.jpg",Name="Kiri"}
};

        }

        public class premio
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
        }
        private ObservableCollection<premio> premios;
  

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}

