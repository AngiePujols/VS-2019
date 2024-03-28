using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECO2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Plantas_Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
