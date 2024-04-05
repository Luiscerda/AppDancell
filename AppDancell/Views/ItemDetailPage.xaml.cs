using AppDancell.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppDancell.Views
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