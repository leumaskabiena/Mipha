using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace Mipha.ViewModels
{
    public class MapViewModels : Map
    {
        public List<Position> RouteCoordinates { get; set; }
       // public CustomCircle Circle { get; set; }
        public MapViewModels()
        {
            RouteCoordinates = new List<Position>();
           // Circle = new CustomCircle();
        }
    }
}
