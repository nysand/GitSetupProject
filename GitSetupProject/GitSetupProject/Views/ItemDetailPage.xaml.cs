using System.ComponentModel;
using Xamarin.Forms;
using GitSetupProject.ViewModels;

namespace GitSetupProject.Views
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
