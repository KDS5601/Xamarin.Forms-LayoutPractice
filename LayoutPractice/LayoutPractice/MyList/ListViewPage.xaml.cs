using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutPractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<MiniViewModel> Items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            Items = new ObservableCollection<MiniViewModel>();

            Items.Add(new MiniViewModel { ranColor = FuntionClass.GetRandomColor(), name = "name1", context = "context1" });

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }

    public struct MiniViewModel
    {
        public Color ranColor { get; set; }
        public string name { get; set; }
        public string context { get; set; }
    }
}
