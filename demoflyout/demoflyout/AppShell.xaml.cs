using System;
using System.Collections.Generic;
using demoflyout.ViewModels;
using demoflyout.Views;
using Xamarin.Forms;

namespace demoflyout
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public string ChangeText
        {
            get;
            set;
        }
        public string avatar
        {
            get;
            set;
        }
        public AppShell(string username)
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            ChangeText = username;
            avatar = username[0].ToString();
            BindingContext = this;
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

