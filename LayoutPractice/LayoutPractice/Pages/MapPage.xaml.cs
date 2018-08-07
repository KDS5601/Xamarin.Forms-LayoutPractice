using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace LayoutPractice.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapPage : ContentPage
	{
		public MapPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            backButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();

        }
	}
}