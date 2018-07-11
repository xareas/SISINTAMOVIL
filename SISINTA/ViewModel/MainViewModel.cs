using System;
using Xamarin.Forms;
using System.Threading;
using System.ComponentModel;
using SISINTA.Infrastructure;
using System.Collections.Generic;
using SISINTA.View;

namespace SISINTA.ViewModel
{
    public class MainViewModel : BaseModelView
    {
        public List<MasterPageItem> MenuItems
        {
            get
            {
                return new List<MasterPageItem>() 
                { 
                    new MasterPageItem(){ Titulo="Productores",Icono="productor.png", PageType=typeof(ProdPage)},
                    new MasterPageItem(){ Titulo="Bancos Semilla",Icono="bancos.png", PageType=typeof(BankPage)},
                    new MasterPageItem(){ Titulo="Investigaciones",Icono="transferencia.png", PageType=typeof(InvesPage)},
                    new MasterPageItem(){ Titulo="Reportes",Icono="printer.png", PageType=typeof(InvesPage)},
                    new MasterPageItem(){ Titulo="Acerca de...",Icono="about.png", PageType=typeof(AboutPage)},
                };
            }
        };

        private Command _menuItemCommand
        public Command MenuItemCommand
        {
            return _menuItemCommand ?? 
                (_menuItemCommand = new Command<MasterPageItem>(async (item)=>{ await ExecuteMenuCommand(item)});              
        }

public async Task ExecuteMenuCommand(MasterPageItem item)
{
    if (item != null)
    {
        var navPage = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
        navPage.BarBackgroundColor = Color.FromHex("#F04158");
        Detail = navPage;
        masterPage.ListView.SelectedItem = null;
        IsPresented = false;
    }

}
public MainViewModel()
{
}
}
}
