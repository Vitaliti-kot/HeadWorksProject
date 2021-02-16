using System.ComponentModel;
using Xamarin.Forms;
using XamarinHeadWorksProject.ViewModels;

namespace XamarinHeadWorksProject.Views
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