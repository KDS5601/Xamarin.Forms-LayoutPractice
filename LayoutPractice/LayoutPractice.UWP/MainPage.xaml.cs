using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace LayoutPractice.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Xamarin.FormsMaps.Init("AmvLODUvhRoAcKTCLYRhkz4oxGxRo5-iCdLxAYHpPpHlp6uOY5u_qMbzc4BQ_aKi");

            LoadApplication(new LayoutPractice.App());
        }
    }
}
