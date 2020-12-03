using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astrodhyaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterNavigation : MasterDetailPage
    {
        public MasterNavigation()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;            
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterNavigationMasterMenuItem;
            if (item == null)
                return;
            if (item.TargetType == typeof(Astrodhyaan.Views.Forms.Share))
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Uri = new Uri("http://astrodhaam.com/demo").ToString(),
                    Title = "Share Web Link"
                });
            }
            var page = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            page.Title = item.Title;

            await Detail.Navigation.PushAsync(page, true);

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}