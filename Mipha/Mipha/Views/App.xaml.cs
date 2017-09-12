using Mipha.Models;
using Mipha.Services;
using Mipha.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Mipha
{
    public partial class App : Application
    {
        static SelectionMockDataStore database;
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }
        public static SelectionMockDataStore Database
        {
            get
            {
                if (database == null)
                {
                    database = new SelectionMockDataStore();
                }
                return database;
            }
        }
        public static void SetMainPage()
        {
            Current.MainPage = new SelectionPage();
            //{
            //    Children =
            //    {
            //        new NavigationPage(new MapView())
            //        {
            //            Title = "Browse",
            //            Icon = Device.OnPlatform("tab_feed.png",null,null)
            //        },
            //        new NavigationPage(new AboutPage())
            //        {
            //            Title = "About",
            //            Icon = Device.OnPlatform("tab_about.png",null,null)
            //        },
            //    }
            //};
        }
      
    }
}
