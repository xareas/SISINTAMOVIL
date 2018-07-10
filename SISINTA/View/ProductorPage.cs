using System;

using Xamarin.Forms;

namespace SISINTA.View
{
    public class ProductorPage : ContentPage
    {
        public ProductorPage()
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

