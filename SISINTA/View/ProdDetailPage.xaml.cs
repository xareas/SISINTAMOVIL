using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SISINTA.Model;
using Xamarin.Forms.Maps;

namespace SISINTA.View
{
    public partial class ProdDetailPage : ContentPage
    {
        public ProdDetailPage(Productor productor)
        {
            InitializeComponent();

            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(productor.Latitud,productor.Longitud),
                                                          Distance.FromKilometers(.5)));

            mapa.Pins.Add(new Pin()
            {
                Type = PinType.Place,
                Label = productor.Nombre,
                Position = new Position(productor.Latitud, productor.Longitud)
            });

            nombre.Text = productor.Nombre;
            departamento.Text = productor.Departamento;
            municipio.Text = productor.Municipio;
            comunidad.Text = productor.Comunidad;
            tipo.Text = productor.TipoFiit;

        }
    }
}
