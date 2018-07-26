using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutPractice
{
    class FuntionClass
    {
        public static Color GetRandomColor()
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
