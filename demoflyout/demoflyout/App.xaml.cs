using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using demoflyout.Services;
using demoflyout.Views;

namespace demoflyout
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

