//using Mipha.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace Mipha.Views
//{
//	[XamlCompilation(XamlCompilationOptions.Compile)]
//	public partial class MainSelection : ContentPage
//	{
//        private ServiceData ob = new ServiceData();
//		public MainSelection ()
//		{
//			InitializeComponent ();
//            btnhuman.Clicked += Btnhuman_Clicked;
//            btnanimal.Clicked += Btnanimal_Clicked;
//            btnplant.Clicked += Btnplant_Clicked;
           
//        }

//        private async void Btnplant_Clicked(object sender, EventArgs e)
//        {
           
//            //  move the position of each button
//            layouthost.IsVisible = true;
//            switch (Device.RuntimePlatform)
//            {
//                case Device.iOS:
//                case Device.Android:
//                    await btnhuman.TranslateTo(100, 0, 200, Easing.Linear);
//                    await btnanimal.TranslateTo(-100, -50, 200, Easing.Linear);
//                    await btnplant.TranslateTo(0, -50, 200, Easing.Linear);
//                    break;
//                default:
//                    await btnhuman.TranslateTo(100, 0, 200, Easing.Linear);
//                    await btnanimal.TranslateTo(-100, -50, 200, Easing.Linear);
//                    await btnplant.TranslateTo(0, -50, 200, Easing.Linear);
//                    break;
//            }
            

//             // resize the Plant button and disable it because it's active 
//            await btnplant.ScaleTo(1.5, 100, Easing.Linear);
          
//            if (btnhuman.Scale > 1)
//            {
//                await btnhuman.ScaleTo(1, 100, Easing.Linear);
//            }
//            if (btnanimal.Scale > 1)
//            {
//                await btnanimal.ScaleTo(1, 100, Easing.Linear);
//            }
//            btnplant.IsEnabled = false;
//            btnanimal.IsEnabled = true;
//            btnhuman.IsEnabled = true;

//            listHost.ItemsSource = ob.FindHost("Plant");
            
//        }

//        private async void Btnhuman_Clicked(object sender, EventArgs e)
//        { 
//            // move the position of each button
//            layouthost.IsVisible = true;
//            await btnanimal.TranslateTo(100, -50, 200, Easing.Linear);
//            await btnplant.TranslateTo(-100, -100, 200, Easing.Linear);
//            await btnhuman.TranslateTo(0, 50, 200, Easing.Linear);
 
//            //resize the Plant button and disable it because it's active   
//            await btnhuman.ScaleTo(1.5, 100, Easing.Linear);
//            if (btnplant.Scale>1)
//            {
//                await btnplant.ScaleTo(1, 100, Easing.Linear); 
//            }
//            if (btnanimal.Scale>1)
//            {
//                await btnanimal.ScaleTo(1, 100, Easing.Linear); 
//            }
//            btnhuman.IsEnabled = false;
//            btnplant.IsEnabled = true;
//            btnanimal.IsEnabled = true;
//            listHost.ItemsSource = ob.FindHost("Human");
//        }
//        private async void Btnanimal_Clicked(object sender, EventArgs e)
//        {
//            //  move the position of each button
//            layouthost.IsVisible = true;
//            await btnhuman.TranslateTo(100, 0, 200, Easing.Linear);
//            await btnplant.TranslateTo(-100, -100, 200, Easing.Linear);
//            await btnanimal.TranslateTo(0, 0, 200, Easing.Linear);

//            // resize the Plant button and disable it because it's active 
//            await btnanimal.ScaleTo(1.5, 100, Easing.Linear);
//            if (btnplant.Scale>1)
//            {
//                await btnplant.ScaleTo(1, 100, Easing.Linear); 
//            }
//            if (btnhuman.Scale>1)
//            {
//                await btnhuman.ScaleTo(1, 100, Easing.Linear); 
//            }

//            btnanimal.IsEnabled = false;
//            btnplant.IsEnabled = true;
//            btnhuman.IsEnabled = true;

//            listHost.ItemsSource = ob.FindHost("Aminal");
//        }

//         void HandleHost_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
//        {
//            if (e.SelectedItem == null)
//                return;

//            //subtitle.IsEnabled = true;
//            //subtitle.Items.Add("samuel");
            
//            listHost.SelectedItem = null;
//            layoutcondition.IsVisible= true;
//            layouthost.IsVisible = false;
//            listCondition.ItemsSource = ob.GetCond();
//        }
//        void HandleCondition_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
//        {
//            if (e.SelectedItem == null)
//            {
//                return;
//            }
               
           
//            //subtitle.IsEnabled = true;
//            //subtitle.Items.Add("samuel");

//          //  listCondition.SelectedItem = null;
//        }
//    }
//}