using System;
using System.Collections.Generic;
using XamarinHeadWorksProject.ViewModels;
using XamarinHeadWorksProject.Views;
using Xamarin.Forms;

namespace XamarinHeadWorksProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
