using MobileLocation.Services;
using MobileLocation.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileLocation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LocationPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
