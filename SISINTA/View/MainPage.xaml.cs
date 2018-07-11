using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SISINTA.Infrastructure;
using SISINTA.ViewModel;

namespace SISINTA
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
            masterPage.ListView.ItemSelected += OnItemSelected;

        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if(item!=null)
            {
                var navPage = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
                navPage.BarBackgroundColor = Color.FromHex("#F04158");
                Detail = navPage;
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
