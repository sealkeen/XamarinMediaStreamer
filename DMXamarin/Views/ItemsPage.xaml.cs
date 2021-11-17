﻿using DMXamarin.Models;
using DMXamarin.ViewModels;
using DMXamarin.Views;
using MediaManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DMXamarin.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
            App.StatusLabel = lblStatus;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            CrossMediaManager.Current.PlayPause();
        }
    }
}