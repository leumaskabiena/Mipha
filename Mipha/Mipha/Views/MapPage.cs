using Mipha.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Mipha.Views
{
    public class MapPage : ContentPage
    {
       
        public MapPage()
        {
            var customMap = new MapViewModels
            {
                MapType = MapType.Street,
                //WidthRequest = App.ScreenWidth,
                //HeightRequest = App.ScreenHeight,
                VerticalOptions=LayoutOptions.FillAndExpand
            };
            var pin = new Pin
            {
                Position = new Position(-29.458696, 30.2864449),
                Label = "we are having fun",
                Address = "29 Daisy Rd, Leonard, Hilton, 3245"
            };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-29.458696, 30.2864449), Distance.FromMiles(1.0)));

            Content = customMap;
        }
    }
}