using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Astrodhyaan.iOS.Renderers;
using Astrodhyaan.Views.Forms;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(Astrodhyaan.Views.Forms.TLScrollView), typeof(TLScrollViewRenderer))]
namespace Astrodhyaan.iOS.Renderers
{
    class TLScrollViewRenderer : ScrollViewRenderer
    {
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var element = e.NewElement as TLScrollView;
			element?.Render();
		}
	}
}