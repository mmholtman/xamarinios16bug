using System.ComponentModel;
using Xamarin.Forms;
using testProject.ViewModels;

namespace testProject.Views
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
