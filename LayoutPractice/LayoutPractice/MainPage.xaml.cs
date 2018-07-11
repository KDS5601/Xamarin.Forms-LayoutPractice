using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutPractice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();

            StackLayout ContentStack = new StackLayout();
            Content = ContentStack;
            ContentStack.VerticalOptions = LayoutOptions.Center;

            LayoutButton StackButton = new LayoutButton("StackLayout");
            StackButton.Clicked += async (object sender, EventArgs e) =>
            await Navigation.PushAsync(new StackPage());

            LayoutButton GridButton = new LayoutButton("Grid");
            GridButton.Clicked += async (object sender, EventArgs e) =>
            await Navigation.PushAsync(new GridPage());

            ContentStack.Children.Add(StackButton);
            ContentStack.Children.Add(GridButton);
        }

        class LayoutButton : Button
        {
            public LayoutButton (string Name_p)
            {
                HeightRequest = 50;
                WidthRequest = 200;
                Text = Name_p;
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
                BackgroundColor = Color.Aqua;
            }
        }
	}
}