using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LayoutPractice.Pages;
using LayoutPractice.MyList;

namespace LayoutPractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            StackLayout ContentStack = new StackLayout();
            Content = ContentStack;
            ContentStack.VerticalOptions = LayoutOptions.Center;

            ContentStack.Children.Add(new LayoutButton("StackLayout", new StackPage()));
            ContentStack.Children.Add(new LayoutButton("Grid", new GridPage()));
            ContentStack.Children.Add(new LayoutButton("ListViewPage", new ListViewPage()));
            ContentStack.Children.Add(new LayoutButton("NumberPad", new NumberPad()));
            ContentStack.Children.Add(new LayoutButton("TextInput", new TextInputPage()));
            ContentStack.Children.Add(new LayoutButton("WebView", new WebViewPage()));
            ContentStack.Children.Add(new LayoutButton("MapPage", new MapPage()));
        }

        class LayoutButton : Button
        {
            public LayoutButton(string Name_p, Page page)
            {
                HeightRequest = 50;
                WidthRequest = 200;
                Text = Name_p;
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
                BackgroundColor = Color.Aqua;

                this.Clicked += async (sender, e) =>
                await Navigation.PushAsync(page);
            }
        }
    }
}