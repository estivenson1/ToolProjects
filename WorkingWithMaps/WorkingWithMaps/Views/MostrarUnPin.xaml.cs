using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace WorkingWithMaps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarUnPin : ContentPage
    {
        public MostrarUnPin()
        {
            InitializeComponent();
        }

        private async void map_MapClicked(object sender, Xamarin.Forms.Maps.MapClickedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Position.Latitude}, {e.Position.Longitude}");
           await DisplayAlert("Información", $"MapClick: {e.Position.Latitude}, {e.Position.Longitude}","Aceptar");
        }

        private async void Pin_InfoWindowClicked(object sender, Xamarin.Forms.Maps.PinClickedEventArgs e)
        {
            e.HideInfoWindow = true;
            string pinName = ((Pin)sender).Label;
            await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");

        }

        private async void Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            //e.HideInfoWindow = false;
            //string pinName = ((Pin)sender).Label;
            //await DisplayAlert("Pin Clicked", $"{pinName} was clicked.", "Ok");
        }
    }
}