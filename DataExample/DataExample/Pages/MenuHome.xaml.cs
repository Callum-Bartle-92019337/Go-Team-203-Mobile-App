﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuHome : ContentPage
    {
        public MenuHome()
        {
            InitializeComponent();
        }

        private void Activities_Button_OnClicked(object sender, EventArgs e)
        {
            //Simple Navigation
            Navigation.PushAsync(new ActivityList());
        }

        private void Phrases_Button_OnClicked(object sender, EventArgs e)
        {
            //Simple Navigation
            Navigation.PushAsync(new MenuPhrases());
        }

        private void New_Button_OnClicked(object sender, EventArgs e)
        {
            //Simple Navigation
            Navigation.PushAsync(new MenuAdmin());
        }
    }
}