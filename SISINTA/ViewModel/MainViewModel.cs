using System;
using Xamarin.Forms;
using System.Threading;
using System.ComponentModel;
using SISINTA.Infrastructure;
using System.Collections.Generic;
using SISINTA.View;
using System.Threading.Tasks;

namespace SISINTA.ViewModel
{
	public class MainViewModel 
    {
        public MainViewModel()
        {
        }

        #region Elementos del Menu Principal
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
        }

        #endregion

      
        #region Clic para Ejecutar el Comando
        public async Task ExecuteMenuCommand(MasterPageItem item)
        {
            if (item != null)
            {
                var navPage = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
                navPage.BarBackgroundColor = Color.FromHex("#F04158");
                //Detail = navPage;
                //masterPage.ListView.SelectedItem = null;
                // IsPresented = false;
            }

        }
        #endregion



    }  //fin   
}
