using demoflyout.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using demoflyout.Models;
using System.Text;
using Xamarin.Forms;

namespace demoflyout.ViewModels
{
    public class LoginViewModel : BaseViewModel,INotifyPropertyChanged
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        private bool _isvalid;
        public bool isvalid
        {
            get
            {
                return _isvalid;
            }
            set
            {
                _isvalid = value;
            }
        }
        private bool _btnenabled;
        public bool btnenabled
        {
            get
            {
                return _btnenabled;
            }
            set
            {
                _btnenabled = value;
            }
        }

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (_isvalid.Equals(true))
            {
                btnenabled = false;
                return;
            }
            //await Shell.Current.GoToAsync($"//{nameof(AppShell)}");
            //DataBase db = new DataBase(App.DatabaseLocation);
            //await db.SaveuserAsync(new user
            //{
            //    username = UserName
            //});

            user users = new user()
            {
                username = UserName
            };
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof(AppShell)}");
            await App.Current.MainPage.Navigation.PushModalAsync(new AppShell(UserName));

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
