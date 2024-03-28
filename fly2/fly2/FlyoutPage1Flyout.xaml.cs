using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fly2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1Flyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPage1Flyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPage1FlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPage1FlyoutViewModel
        {
            public ObservableCollection<FlyoutPage1FlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPage1FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPage1FlyoutMenuItem>(new[]
                {
                    new FlyoutPage1FlyoutMenuItem { Id = 0, Title = "Calculadora",IconSource="calculator.png", TargetType = typeof(Page1) },
                    new FlyoutPage1FlyoutMenuItem { Id = 1, Title = "Perfil",IconSource="icon2.png", TargetType = typeof(Page2) },
                    new FlyoutPage1FlyoutMenuItem { Id = 2, Title = "Grid",IconSource="grid.png", TargetType = typeof(Page3) },
                    new FlyoutPage1FlyoutMenuItem { Id = 3, Title = "Starklayout", IconSource="webdesign.png",TargetType = typeof(Page4) },
                    new FlyoutPage1FlyoutMenuItem { Id = 4, Title = "Tabbed", IconSource="cellphone.png",TargetType = typeof(TabbedPage2)}, 
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            #endregion
        }
    }

}