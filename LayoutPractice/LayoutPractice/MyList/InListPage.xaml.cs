using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutPractice.MyList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InListPage : ContentPage
    {
        public InListPage(int id, string name, string context)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            backButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();

            idLabel.Text = id.ToString();
            nameLabel.Text = name;
            contextLabel.Text = context;
        }
    }
}