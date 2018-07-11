using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SISINTA.Model;

namespace SISINTA.View
{
    public partial class ProdListPage : ContentPage
    {
        public ProdListPage()
        {
            InitializeComponent();
            lvwProductor.ItemsSource = FakesData.Productores;
        }

        async void ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var productor = (Productor)e.Item;
            await Navigation.PushAsync(new ProdDetailPage(productor));
            lvwProductor.SelectedItem = null;
        }
    }
}
