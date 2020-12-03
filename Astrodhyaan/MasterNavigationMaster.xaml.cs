using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Astrodhyaan.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astrodhyaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterNavigationMaster : ContentPage
    {
        public ListView ListView;

        public MasterNavigationMaster()
        {
            InitializeComponent();

            BindingContext = new MasterNavigationMasterViewModel();
            ListView = MenuItemsListView;            
        }

        class MasterNavigationMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterNavigationMasterMenuItem> MenuItems { get; set; }

            public MasterNavigationMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterNavigationMasterMenuItem>(new[]
                {
                    new MasterNavigationMasterMenuItem { Id = 0,ImgName="home.png", Title = "Home Page",TargetType=typeof(Astrodhyaan.Views.Forms.LoginPage) },
                    new MasterNavigationMasterMenuItem { Id = 1,ImgName="refresh.png", Title = "Astrodhyaan Updates",TargetType=typeof(Astrodhyaan.Views.Forms.AstroUpdate) },
                    new MasterNavigationMasterMenuItem { Id = 3,ImgName="support.png", Title = "Customer Support" ,TargetType=typeof(Astrodhyaan.Views.Forms.CustomerSupport)},
                    new MasterNavigationMasterMenuItem { Id = 4,ImgName="aboutus.png", Title = "About Us",TargetType=typeof(Astrodhyaan.Views.Forms.AboutUs) },                    
                    new MasterNavigationMasterMenuItem { Id = 5,ImgName="rate.png", Title = "Rate Astrodyhaan" },
                    new MasterNavigationMasterMenuItem { Id = 6,ImgName="share.png", Title = "Share" ,TargetType=typeof(Astrodhyaan.Views.Forms.Share)},
                    new MasterNavigationMasterMenuItem { Id = 7,ImgName="privacy.png", Title = "Privacy Policy" ,TargetType=typeof(Astrodhyaan.Views.Forms.PrivacyPolicy)},
                    new MasterNavigationMasterMenuItem { Id = 8,ImgName="exit.png", Title = "Sign Out" },
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