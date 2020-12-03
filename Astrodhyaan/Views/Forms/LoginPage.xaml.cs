using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Astrodhyaan.ViewModels;
using Astrodhyaan.Models;
using System.Collections;
using FormsControls.Base;
using System.Threading;
using Plugin.Messaging;
using Xamarin.Essentials;

namespace Astrodhyaan.Views.Forms
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>     
    public partial class LoginPage:AnimationPage
    {
        public HomePageViewModel HPM;
        private ActivityIndicator ai;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage" /> class.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            //places = GetPlaces();
            //this.BindingContext = this;

            
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
            //    Children = { ai, cvAstro },
            //    Orientation = StackOrientation.Vertical
            //};
            cvAstro.IsVisible = false;
            cvBanner.IsVisible = false;
            CurrentAstroView.IsVisible = false;
            ExpertView.IsVisible = false;
            cvAstroHead.IsVisible = false;
            AstroView.IsVisible = false;
            cvSearch.IsVisible = false;
            ActInd.IsVisible = true;


            //BindingContext = HPM;
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#FDAF97");
            //((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("#000000");

            Thread t = new Thread(() => setContentAsync());
            t.Start();
        }
        [Obsolete]
        private async Task setContentAsync()
        {
            await Task.Delay(500);
            HPM = new HomePageViewModel();
            Device.BeginInvokeOnMainThread(() => {
                BindingContext = HPM;
                //cvAstro.ItemsSource = HPM.Astrologers;
                //CurrentAstroView.SetBinding<HomePageViewModel>(BindableLayout.ItemsSourceProperty, HPM => HPM.Astrologers);
                //ExpertView.SetBinding<HomePageViewModel>(BindableLayout.ItemsSourceProperty, HPM => HPM.Items);
                //CurrentAstroView.BindingContext = new ObservableCollection<AstrologerEntity>(HPM.Astrologers);
                //ExpertView.BindingContext = new ObservableCollection<AstrologyExpertItem>(HPM.Items);
                CurrentAstroView.IsVisible = true;
                cvSearch.IsVisible = true;
                cvAstro.IsVisible = true;
                cvBanner.IsVisible = true;
                AstroView.IsVisible = true;
                ExpertView.IsVisible = true;
                cvAstroHead.IsVisible = true;
                ActInd.IsVisible = false;
                Device.StartTimer(TimeSpan.FromSeconds(10), (Func<bool>)(() =>
                {
                    cvAstro.Position = (cvAstro.Position + 1) % HPM.Astrologers.Count;
                    return true;
                })
                );
                Device.StartTimer(TimeSpan.FromSeconds(10), (Func<bool>)(() =>
                {
                    cvBanner.Position = (cvBanner.Position + 1) % 3;
                    return true;
                })
                );
                //ai.IsVisible = false;
                //MyListView.IsVisible = true;
            });
        }
        private async void AstroTop_Clicked(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Grid))
            {
                string classid = string.Empty;
                Grid grid = sender as Grid;
                classid = grid.ClassId;
                await Navigation.PushAsync(new Horoscope(classid), true);
            }
            else
            {
                var stack = sender as StackLayout;
                AstrologerEntity ae = ((HomePageViewModel)BindingContext).Astrologers.FirstOrDefault(x => x.Id == Convert.ToInt64(((TappedEventArgs)e).Parameter));
                await Navigation.PushAsync(new AstrologerProfile(ae), true);
            }
        }

            private async Task Flip(VisualElement from, VisualElement to)
        {
            await from.RotateYTo(-90, 300, Easing.SpringIn);
            to.RotationY = 90;
            to.IsVisible = true;
            from.IsVisible = false;
            await to.RotateYTo(0, 300, Easing.SpringOut);
        }

        private async void FlipToBack(object sender, EventArgs e)
        {
            var front = sender as Grid;
            var back = front.Parent.FindByName<Grid>("BackView");
            await Flip(front, back);
        }

        private async void FlipToFront(object sender, EventArgs e)
        {
            var back = sender as Grid;
            var front = back.Parent.Parent.Parent.Parent.Parent.FindByName<Grid>("FrontView");
            var bk =back.Parent.Parent.Parent.Parent as Grid;
            await Flip(bk, front);
        }

        private async void btnExploreAll_Clicked(object sender, EventArgs e)
        {
            Button btn;
            StackLayout stack;
            string classid = string.Empty;
            if (sender.GetType() == typeof(Button))
            {
                btn = sender as Button;
                classid = btn.ClassId.Replace("_", " ");
            }
            else
            {
                stack = sender as StackLayout;
                classid = stack.ClassId.Replace("_", " ");
            }
            //var page = new NavigationPage(new Forms.AstrologersList());           
            await Navigation.PushAsync(new AstrologersList(HPM.Astrologers,classid),true);
        }

        private async void tapWallet_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Payment(HPM.UserDetail), true);
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(), true);
        }

        private async void btnAccount_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserAccount(HPM.UserDetail), true);
        }

        private async void btnWallet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Payment(HPM.UserDetail), true);
        }

        private async void btnCall_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new SignUp(), true);
            try
            {                
                CrossMessaging.Current.PhoneDialer.MakePhoneCall("+917021209461");
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
    public class TLScrollView : ScrollView
    {
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create("ItemsSource", typeof(IEnumerable), typeof(TLScrollView), default(IEnumerable));

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly BindableProperty ItemTemplateProperty =
            BindableProperty.Create("ItemTemplate", typeof(DataTemplate), typeof(TLScrollView), default(DataTemplate));

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }
        public void Render()
        {
            if (this.ItemTemplate == null || this.ItemsSource == null)
                return;

            var layout = new StackLayout();
            layout.Orientation = this.Orientation == ScrollOrientation.Vertical
                ? StackOrientation.Vertical : StackOrientation.Horizontal;

            foreach (var item in this.ItemsSource)
            {
                var viewCell = this.ItemTemplate.CreateContent() as ViewCell;
                viewCell.View.BindingContext = item;
                layout.Children.Add(viewCell.View);
            }

            this.Content = layout;
        }
    }

}