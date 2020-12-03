using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astrodhyaan.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horoscope : TabbedPage
    {
        public Horoscope(string horoscope)
        {           
            InitializeComponent();
            BarTextColor = Color.White;
            BarBackgroundColor = Color.FromHex("#c8c7c8");
            if (horoscope.ToUpper() == "ARIES")
            {
                lblHead.Text = "Horoscope - ARIES";
                lblToday.Text = "ARIES Today data goes here";
                lblWeek.Text = "ARIES Week data goes here";
                lblMonth.Text = "ARIES Month data goes here";
                lblTomorrow.Text = "ARIES Tomorrow data goes here";
                lbl2020.Text = "ARIES 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "TAURUS")
            {
                lblHead.Text = "Horoscope - TAURUS";
                lblToday.Text = "TAURUS Today data goes here";
                lblWeek.Text = "TAURUS Week data goes here";
                lblMonth.Text = "TAURUS Month data goes here";
                lblTomorrow.Text = "TAURUS Tomorrow data goes here";
                lbl2020.Text = "TAURUS 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "GEMINI")
            {
                lblHead.Text = "Horoscope - GEMINI";
                lblToday.Text = "GEMINI Today data goes here";
                lblWeek.Text = "GEMINI Week data goes here";
                lblMonth.Text = "GEMINI Month data goes here";
                lblTomorrow.Text = "GEMINI Tomorrow data goes here";
                lbl2020.Text = "GEMINI 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "CANCER")
            {
                lblHead.Text = "Horoscope - CANCER";
                lblToday.Text = "CANCER Today data goes here";
                lblWeek.Text = "CANCER Week data goes here";
                lblMonth.Text = "CANCER Month data goes here";
                lblTomorrow.Text = "CANCER Tomorrow data goes here";
                lbl2020.Text = "CANCER 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "LEO")
            {
                lblHead.Text = "Horoscope - LEO";
                lblToday.Text = "LEO Today data goes here";
                lblWeek.Text = "LEO Week data goes here";
                lblMonth.Text = "LEO Month data goes here";
                lblTomorrow.Text = "LEO Tomorrow data goes here";
                lbl2020.Text = "LEO 2020 data goes here";
            }            
            else if (horoscope.ToUpper() == "VIRGO")
            {
                lblHead.Text = "Horoscope - VIRGO";
                lblToday.Text = "VIRGO Today data goes here";
                lblWeek.Text = "VIRGO Week data goes here";
                lblMonth.Text = "VIRGO Month data goes here";
                lblTomorrow.Text = "VIRGO Tomorrow data goes here";
                lbl2020.Text = "VIRGO 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "LIBRA")
            {
                lblHead.Text = "Horoscope - LIBRA";
                lblToday.Text = "LIBRA Today data goes here";
                lblWeek.Text = "LIBRA Week data goes here";
                lblMonth.Text = "LIBRA Month data goes here";
                lblTomorrow.Text = "LIBRA Tomorrow data goes here";
                lbl2020.Text = "LIBRA 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "SCORPIO")
            {
                lblHead.Text = "Horoscope - SCORPIO";
                lblToday.Text = "SCORPIO Today data goes here";
                lblWeek.Text = "SCORPIO Week data goes here";
                lblMonth.Text = "SCORPIO Month data goes here";
                lblTomorrow.Text = "SCORPIO Tomorrow data goes here";
                lbl2020.Text = "SCORPIO 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "SAGITTARIUS")
            {
                lblHead.Text = "Horoscope - SAGITTARIUS";
                lblToday.Text = "SAGITTARIUS Today data goes here";
                lblWeek.Text = "SAGITTARIUS Week data goes here";
                lblMonth.Text = "SAGITTARIUS Month data goes here";
                lblTomorrow.Text = "SAGITTARIUS Tomorrow data goes here";
                lbl2020.Text = "SAGITTARIUS 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "CAPRICORN")
            {
                lblHead.Text = "Horoscope - CAPRICORN";
                lblToday.Text = "CAPRICORN Today data goes here";
                lblWeek.Text = "CAPRICORN Week data goes here";
                lblMonth.Text = "CAPRICORN Month data goes here";
                lblTomorrow.Text = "CAPRICORN Tomorrow data goes here";
                lbl2020.Text = "CAPRICORN 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "AQUARIUS")
            {
                lblHead.Text = "Horoscope - AQUARIUS";
                lblToday.Text = "AQUARIUS Today data goes here";
                lblWeek.Text = "AQUARIUS Week data goes here";
                lblMonth.Text = "AQUARIUS Month data goes here";
                lblTomorrow.Text = "AQUARIUS Tomorrow data goes here";
                lbl2020.Text = "AQUARIUS 2020 data goes here";
            }
            else if (horoscope.ToUpper() == "PISCES")
            {
                lblHead.Text = "Horoscope - PISCES";
                lblToday.Text = "PISCES Today data goes here";
                lblWeek.Text = "PISCES Week data goes here";
                lblMonth.Text = "PISCES Month data goes here";
                lblTomorrow.Text = "PISCES Tomorrow data goes here";
                lbl2020.Text = "PISCES 2020 data goes here";
            }
        }
    }
}