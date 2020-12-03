using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Astrodhyaan.ViewModels;

namespace Astrodhyaan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RattingBarPage : ContentPage
    {
        public RattingBarPage()
        {
            InitializeComponent();
            this.BindingContext = new RattingBarViewModal();
        }
    }
}