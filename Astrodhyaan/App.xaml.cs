using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astrodhyaan
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterNavigation();
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
