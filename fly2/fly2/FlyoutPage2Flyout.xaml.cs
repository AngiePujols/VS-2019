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
    public partial class FlyoutPage2Flyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPage2Flyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPage2FlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class FlyoutPage2FlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPage2FlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPage2FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPage2FlyoutMenuItem>(new[]
                {
                    new FlyoutPage2FlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new FlyoutPage2FlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new FlyoutPage2FlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new FlyoutPage2FlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new FlyoutPage2FlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}