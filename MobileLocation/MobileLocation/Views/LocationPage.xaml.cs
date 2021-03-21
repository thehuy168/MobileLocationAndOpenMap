using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileLocation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {

                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(45)
                    });
                }
                if (location == null)
                    LabelLocation.Text = "No GPS";
                else
                    LabelLocation.Text = $"{location.Latitude}{location.Longitude}"; // vido - kinh do 
                var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };
                await Map.OpenAsync(location, options); // mo ban do ung voi toa do 
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Something is wrong :{ ex.Message}");
            }
        }
    }
}