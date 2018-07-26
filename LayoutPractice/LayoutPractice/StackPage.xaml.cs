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
	public partial class StackPage : ContentPage
	{
		public StackPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();

            BackButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();

            addButton.Clicked += (sender, e) =>
            {
                childrenStack.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = FuntionClass.GetRandomColor()
                }
                );
            };
        }
    }
}