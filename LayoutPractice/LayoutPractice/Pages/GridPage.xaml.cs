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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            BackButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();

            ChangeButton.Clicked += (sender, e) =>
            ChangeColor();
        }

        private async void ChangeColor()
        {
            Label1.BackgroundColor = FuntionClass.GetRandomColor();
            await Task.Delay(50);
            Label2.BackgroundColor = FuntionClass.GetRandomColor();
            await Task.Delay(50);
            Label3.BackgroundColor = FuntionClass.GetRandomColor();
            await Task.Delay(50);
            ChangeButton.BackgroundColor = FuntionClass.GetRandomColor();
            await Task.Delay(50);
            BackButton.BackgroundColor = FuntionClass.GetRandomColor();
            await Task.Delay(50);
        }


    }
}