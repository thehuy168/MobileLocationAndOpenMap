﻿using MobileLocation.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileLocation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}