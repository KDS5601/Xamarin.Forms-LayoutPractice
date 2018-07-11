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
            Label1.BackgroundColor = GetRandomColor();
            await Task.Delay(50);
            Label2.BackgroundColor = GetRandomColor();
            await Task.Delay(50);
            Label3.BackgroundColor = GetRandomColor();
            await Task.Delay(50);
            ChangeButton.BackgroundColor = GetRandomColor();
            await Task.Delay(50);
            BackButton.BackgroundColor = GetRandomColor();
            await Task.Delay(50);
        }

        private Color GetRandomColor ()
        {
            Random RandomNumber = new Random();

            int RandomRed = RandomNumber.Next(0, 255);
            int RandomGreen = RandomNumber.Next(0, 255);
            int RandomBlue = RandomNumber.Next(0, 255);

            Color ReturnColor = Color.FromRgb(RandomRed, RandomGreen, RandomBlue);

            return ReturnColor;
        }
    }
}