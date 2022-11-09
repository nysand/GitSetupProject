using System;
using System.Collections.Generic;
using GitSetupProject.ViewModels;
using GitSetupProject.Views;
using Xamarin.Forms;

namespace GitSetupProject
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

