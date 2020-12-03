﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FormsControls.Base;
namespace Astrodhyaan
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : AnimationPage
    {
        public MainPage() 
        {
            InitializeComponent();
            this.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("#fff0db"));
            this.SetValue(NavigationPage.BarTextColorProperty, Color.Black);
        }
    }
}
