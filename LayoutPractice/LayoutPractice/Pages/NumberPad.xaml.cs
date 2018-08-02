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
    public partial class NumberPad : ContentPage
    {
        public NumberPad()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            backButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();
            

            inputLabel.Text = "";
            Button[] inputNumberButtons = new Button[10];
            Button clearButton = new Button { Text = "clr" };
            
            const int maxNumber = 99_999_999;
            int chackNumber = 0;

            clearButton.Clicked += (sender, e) =>
            {
                inputLabel.Text = "";
                chackNumber = 0;
            };

            for (int i = 0; i < 10; ++i)
            {
                inputNumberButtons[i] = new Button
                {
                    Text = (i).ToString()
                };
            }

            foreach (Button button in inputNumberButtons)
            {
                if (button.Text == "0")
                {
                    button.Clicked += (sender, e) =>
                    {
                        if (inputLabel.Text != "")
                        {
                            chackNumber = Convert.ToInt32(inputLabel.Text);

                            if (chackNumber < maxNumber)
                            {
                                inputLabel.Text += inputNumberButtons[0].Text;
                            }
                        }
                    };
                }
                else if (button.Text != "0")
                    button.Clicked += (sender, e) =>
                    {
                        if (inputLabel.Text != "")
                            chackNumber = Convert.ToInt32(inputLabel.Text);
                        if (chackNumber < maxNumber)
                            inputLabel.Text += button.Text;
                    };

                button.Clicked += (sender, e) =>
                {
                    if (inputLabel.Text != "")
                    {
                        //do something good
                    }
                };
            }

            int count = 0;

            inputNumbersGrid.Children.Add(clearButton, 2, 3);
            inputNumbersGrid.Children.Add(inputNumberButtons[count], 0, 3);

            Grid.SetColumnSpan(inputNumberButtons[count], 2);

            count++;

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                {
                    inputNumbersGrid.Children.Add(inputNumberButtons[count++], j, i);
                }
        }
    }
}