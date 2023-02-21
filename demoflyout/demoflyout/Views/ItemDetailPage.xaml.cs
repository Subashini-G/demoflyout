using System.ComponentModel;
using Xamarin.Forms;
using demoflyout.ViewModels;

namespace demoflyout.Views
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
