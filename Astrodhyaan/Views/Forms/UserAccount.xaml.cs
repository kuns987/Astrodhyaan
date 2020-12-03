using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astrodhyaan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astrodhyaan.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserAccount : TabbedPage
    {
        public UserMasterEntity UserDetail { get; set; }
        public UserAccount(UserMasterEntity userdetail)
        {
            InitializeComponent();
            BarTextColor = Color.White;
            BarBackgroundColor = Color.FromHex("#c8c7c8");
            UserDetail = userdetail;
        }
        protected override async void OnAppearing()
        {
            BindingContext = UserDetail;
        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new AstrologerProfile((AstrologerEntity)e.Item), true);

            ////Deselect Item
            //((ListView)sender).SelectedItem = null;
        }

        private void tapChat_Tapped(object sender, EventArgs e)
        {

        }

        private void tapCall_Tapped(object sender, EventArgs e)
        {

        }
    }
}