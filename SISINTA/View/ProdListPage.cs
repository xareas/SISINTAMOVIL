using System;

using Xamarin.Forms;

namespace SISINTA.View
{
    public class ProdListPage : ContentPage
    {
        public ProdListPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

