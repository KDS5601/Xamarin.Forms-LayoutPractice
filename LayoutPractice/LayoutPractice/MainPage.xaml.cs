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

            ContentStack.Children.Add(StackButton);
        }

        class LayoutButton : Button
        {
            public LayoutButton (string Name_p)
            {
                HeightRequest = 50;
                WidthRequest = 200;
                Text = Name_p;
                BackgroundColor = Color.Aqua;
            }
        }
	}
}