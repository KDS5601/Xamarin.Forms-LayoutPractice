﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LayoutPractice.MyList;

namespace LayoutPractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<MiniViewModel> Items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            backButton.Clicked += async (sender, e) =>
            await Navigation.PopAsync();

            Items = new ObservableCollection<MiniViewModel>();

            EnterButton.Clicked += (sender, e) =>
            {
                string name;
                string context;

                name = NameEntry.Text;
                context = ContextEntry.Text;

                Items.Add(new MiniViewModel { RanColor = FuntionClass.GetRandomColor(), Name = name, Context = context });

                NameEntry.Text = "기본이름";
                ContextEntry.Text = "기본값";
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //sender는 구독한놈 ??
            //e는 매개변수
            //e.Group은 들어온 클래스

            MiniViewModel m = e.Group as MiniViewModel;

            await Navigation.PushAsync(new InListPage(m.ID, m.Name, m.Context));

            ((ListView)sender).SelectedItem = null;
            e = null;
        }
    }

    public class MiniViewModel
    {
        static int IDCount = 0;
        public Color RanColor { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public int ID { get; set; }

        public MiniViewModel()
        {
            ID = IDCount++;
        }
    }
}
