﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoflyout.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoflyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //loginbutton.Opacity = 0.5;
            this.BindingContext = new LoginViewModel();
        }
    }
}
