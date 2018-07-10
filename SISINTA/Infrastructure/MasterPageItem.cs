using System;
namespace SISINTA.Infrastructure
{
    public class MasterPageItem
    {

        public string Titulo { get; set; }

        public string Icono { get; set; }
        /// <summary>
        /// Tipo de Pagina a cargar cuando se presione el item del menu
        /// 
        /// </summary>
        /// <value>Tipo de Pagina a cargar.</value>
        public Type PageType { get; set; }

        public MasterPageItem()
        {
        }
    }
}
