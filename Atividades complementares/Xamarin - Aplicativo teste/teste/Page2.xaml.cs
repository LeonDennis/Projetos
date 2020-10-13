using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Globalization;

namespace teste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            try
            {
                string Latitude = "";
                string Longitude = "";
                var request = new GeolocationRequest(GeolocationAccuracy.Best);
                var location = await Geolocation.GetLocationAsync(request);
                if (location != null)
                {
                    if (location.IsFromMockProvider)
                    {
                        await DisplayAlert("Houve um erro ao encontrar sua localização :(", string.Format("Sua localização não pode ser encontrada. (por acaso você está utilizando algum app de localização fictícia?)"), "OK");
                    }
                    else
                    {
                        Latitude = Convert.ToString(location.Latitude, new CultureInfo("en-US"));
                        Longitude = Convert.ToString(location.Longitude, new CultureInfo("en-US"));
                        bool answer = await DisplayAlert("Localização encontrada com sucesso!", string.Format("A sua latitude é: {0}, e a sua longitude: {1}.", Latitude, Longitude), "OK", "Abrir no Google Maps");
                        if (answer != true)
                        {
                            string url = $"https://www.google.com/maps/search/?api=1&query={Latitude},{Longitude}";
                            Device.OpenUri(new Uri(url));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Houve um erro ao encontrar sua localização :(", string.Format("A localização do dispositivo deve estar ativada para utilizar esta função."), "OK");
            }
        }
    }
}