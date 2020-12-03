using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Astrodhyaan.Views.CustomControls;
namespace Astrodhyaan.ViewModels
{
    class RattingBarViewModal : INotifyPropertyChanged
    {
        public ICommand rattingBarCommand { get; set; }
        public ICommand clickCommand { get; set; }
        public RattingBarViewModal()
        {
            rattingBarCommand = new Command(onItemTapped); // this will execute on tap of image (star)
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.

        }

        void onClicked(object obj)
        {
            RattingBar b = (RattingBar)obj;
            App.Current.MainPage.DisplayAlert("Selected Value is", b.SelectedStarValue.ToString(), "OK");
        }


        private string _selectedStar;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; NotifyPropertyChanged(); }
        }



        private void onItemTapped(object obj)
        {
            var obje = obj;
            SelectedStar = "Selected Star is " + obj;
        }
    }
}
