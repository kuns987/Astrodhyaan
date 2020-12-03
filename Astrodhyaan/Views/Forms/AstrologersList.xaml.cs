using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Astrodhyaan.ViewModels;
using System.Collections;
using Astrodhyaan.Models;
using System.Threading;

namespace Astrodhyaan.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AstrologersList : AnimationPage
    {
        public ObservableCollection<AstrologerEntity> Astrologers { get; set; }
        //private ActivityIndicator ai;
        public AstrologersList(ObservableCollection<AstrologerEntity> astrologers,string head)
        {
            InitializeComponent();
            lblHead.Text = head;
            //MyListView.IsVisible = false;
            //cvSearch.IsVisible = false;
            ActInd.IsVisible = true;
            //ai = new ActivityIndicator
            //{
            //    IsRunning = true,
            //    IsVisible = true,
            //    IsEnabled = true,
            //    HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};
            //Content = new StackLayout
            //{
            //    Children = { ai, MyListView },
            //    Orientation = StackOrientation.Vertical
            //};
            Astrologers = astrologers;
            Thread t = new Thread(() => setContentAsync());
            t.Start();
            
            
            
        }
        private async Task setContentAsync()
        {
            await Task.Delay(1100);
            Device.BeginInvokeOnMainThread(() => {
                MyListView.ItemsSource = Astrologers;
                ActInd.IsVisible = false;
                //MyListView.IsVisible = true;
            });
        }
            //protected override async void OnAppearing()
            //{
            //    MyListView.ItemsSource = Astrologers;
            //}
            async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new AstrologerProfile((AstrologerEntity)e.Item), true);

            ////Deselect Item
            //((ListView)sender).SelectedItem = null;
        }

        private async void tapChat_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp(), true);
        }

        private async void tapCall_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp(), true);
        }
    }
}
