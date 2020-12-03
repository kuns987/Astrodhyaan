using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astrodhyaan.ViewModels;
using Astrodhyaan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsControls.Base;

namespace Astrodhyaan.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AstrologerProfile : AnimationPage
    {
        public AstrologerEntity Astrologer { get; set; }
        public AstrologerProfile(AstrologerEntity astroinfo)
        {
            InitializeComponent();
            Astrologer = astroinfo;
        }
        protected override async void OnAppearing()
        {
            BindingContext = Astrologer;
        }
        private async void tapRemarks_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AstrologerReview((AstrologerEntity)BindingContext), true);
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