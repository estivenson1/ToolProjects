using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
    }
}