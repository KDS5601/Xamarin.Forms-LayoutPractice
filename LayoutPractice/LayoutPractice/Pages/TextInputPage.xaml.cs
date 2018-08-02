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
	public partial class TextInputPage : ContentPage
	{
		public TextInputPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
            backButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();

            NumberOnlyEntry.TextChanged += (sender, e) =>
            {
                if (e.NewTextValue == null)
                {
                    // Completed시 NewTextValue가 null값으로 extChanged하여 진입함
                    return;
                }
                else if (e.NewTextValue == "")
                {
                    ((Entry)sender).Text = "";
                }
                else if (!(int.TryParse(e.NewTextValue, out int i)))
                {
                    ((Entry)sender).Text = e.OldTextValue;
                }
            };
            NumberOnlyEntry.Completed += (sender, e) =>
            {
                NumberOnlyLabel.Text = ((Entry)sender).Text;
                ((Entry)sender).Text = null;
            };

        }
	}
}