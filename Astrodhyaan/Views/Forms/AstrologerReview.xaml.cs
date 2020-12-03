using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astrodhyaan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsControls.Base;

namespace Astrodhyaan.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AstrologerReview : AnimationPage
    {
        public AstrologerEntity Astrologer { get; set; }
        public AstrologerReview(AstrologerEntity astro)
        {
            InitializeComponent();
            Astrologer = astro;
        }
        protected override async void OnAppearing()
        {
            BindingContext = Astrologer;
        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}