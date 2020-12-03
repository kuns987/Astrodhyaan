using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Astrodhyaan.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Application = Android.App.Application;

[assembly: ExportRenderer(typeof(Astrodhyaan.Views.Forms.TLScrollView), typeof(Astrodhyaan.Droid.Renderers.TLScrollViewRenderer))]
namespace Astrodhyaan.Droid.Renderers
{
    class TLScrollViewRenderer : ScrollViewRenderer
    {
        public TLScrollViewRenderer() : base(Application.Context)
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as TLScrollView;
            element?.Render();
        }
    }

}