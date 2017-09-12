using Mipha.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mipha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectionPage : ContentPage
    {
        //public App.Database selv = new SelectionViewModel();
        
        public SelectionPage()
        {
            InitializeComponent();
            btnhuman.Clicked += Btnhuman_Clicked;
            btnanimal.Clicked += Btnanimal_Clicked;
            btnplant.Clicked += Btnplant_Clicked;
            btnpre.Clicked += Btnpre_Clicked;
        }

        private void Btnpre_Clicked(object sender, EventArgs e)
        {
            layouthost.IsVisible = true;
            layoutcondition.IsVisible = false;
            btnpre.IsEnabled = false;
            btnnext.IsEnabled = false;
            if(btnanimal.IsEnabled!=true)
            {
                lbltitle.Text = "Select an  Aminal";
            }
            else if (btnplant.IsEnabled != true)
            {
                lbltitle.Text = "Select a  Plant";
            }
            else if (btnhuman.IsEnabled != true)
            {
                lbltitle.Text = "Select a  Human";
            }
        }

        private async void Btnplant_Clicked(object sender, EventArgs e)
        {
            lbltitle.Text = "Select a  Plant";
            //  move the position of each button
            layouthost.IsVisible = true;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    await btnhuman.TranslateTo(100, 0, 200, Easing.Linear);
                    await btnanimal.TranslateTo(-100, -50, 200, Easing.Linear);
                    await btnplant.TranslateTo(0, -50, 200, Easing.Linear);
                    break;
                default:
                    await btnhuman.TranslateTo(100, 0, 200, Easing.Linear);
                    await btnanimal.TranslateTo(-100, -50, 200, Easing.Linear);
                    await btnplant.TranslateTo(0, -50, 200, Easing.Linear);
                    break;
            }


            // resize the Plant button and disable it because it's active 
            await btnplant.ScaleTo(1.5, 100, Easing.Linear);

            if (btnhuman.Scale > 1)
            {
                await btnhuman.ScaleTo(1, 100, Easing.Linear);
            }
            if (btnanimal.Scale > 1)
            {
                await btnanimal.ScaleTo(1, 100, Easing.Linear);
            }
            btnplant.IsEnabled = false;
            btnanimal.IsEnabled = true;
            btnhuman.IsEnabled = true;

            listHost.ItemsSource = App.Database.GetFindListHost("Plant");

        }

        private async void Btnhuman_Clicked(object sender, EventArgs e)
        {
            // move the position of each button
            lbltitle.Text = "Select a  Human";
            layouthost.IsVisible = true;
            await btnanimal.TranslateTo(100, -50, 200, Easing.Linear);
            await btnplant.TranslateTo(-100, -100, 200, Easing.Linear);
            await btnhuman.TranslateTo(0, 50, 200, Easing.Linear);

            //resize the Plant button and disable it because it's active   
            await btnhuman.ScaleTo(1.5, 100, Easing.Linear);
            if (btnplant.Scale > 1)
            {
                await btnplant.ScaleTo(1, 100, Easing.Linear);
            }
            if (btnanimal.Scale > 1)
            {
                await btnanimal.ScaleTo(1, 100, Easing.Linear);
            }
            btnhuman.IsEnabled = false;
            btnplant.IsEnabled = true;
            btnanimal.IsEnabled = true;
            listHost.ItemsSource = App.Database.GetFindListHost("Human");
        }
        private async void Btnanimal_Clicked(object sender, EventArgs e)
        {
            lbltitle.Text = "Select an  Aminal";
            //  move the position of each button
            layouthost.IsVisible = true;
            await btnhuman.TranslateTo(100, 0, 200, Easing.Linear);
            await btnplant.TranslateTo(-100, -100, 200, Easing.Linear);
            await btnanimal.TranslateTo(0, 0, 200, Easing.Linear);

            // resize the Plant button and disable it because it's active 
            await btnanimal.ScaleTo(1.5, 100, Easing.Linear);
            if (btnplant.Scale > 1)
            {
                await btnplant.ScaleTo(1, 100, Easing.Linear);
            }
            if (btnhuman.Scale > 1)
            {
                await btnhuman.ScaleTo(1, 100, Easing.Linear);
            }

            btnanimal.IsEnabled = false;
            btnplant.IsEnabled = true;
            btnhuman.IsEnabled = true;
           
            listHost.ItemsSource = App.Database.GetFindListHost("Aminal");
        }
        void HandleHost_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var host = e.SelectedItem as Host;
            lbltitle.Text = "Select a condion of a " + host.Host_Name;
            
            listCondition.ItemsSource = App.Database.GetFindListCondition(host.Host_Name);

            listHost.SelectedItem = null;
            layoutcondition.IsVisible = true;
            layouthost.IsVisible = false;
            btnpre.IsEnabled = true;
           // listCondition.ItemsSource = ob.GetCond();
        }
        void HandleCondition_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            btnnext.IsEnabled = true;
            //subtitle.IsEnabled = true;
            //subtitle.Items.Add("samuel");

            //  listCondition.SelectedItem = null;
        }
    }
}