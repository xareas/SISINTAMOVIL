using System;
using System.Collections.Generic;
namespace SISINTA.Model
{
    public static class FakesData
    {
        public static List<Productor> Productores { get; }
        static FakesData()
        {
            #region Inicializando Productores
            Productores = new List<Productor>() {
                new Productor{
                    Nombre="Francisco Javier Areas Rios",
                    Departamento = "Managua",
                    Municipio = "Managua",
                    Comunidad ="La Resbalosa",
                    TipoFiit = "Ganado Silvopastoril",
                    Latitud = 12.1149926,
                    Longitud = -86.23617439999998
                },
                new Productor{
                    Nombre="Nora Patricia Ortiz Chavez",
                    Departamento = "Managua",
                    Municipio = "Managua",
                    Comunidad ="La Resbalosa",
                    TipoFiit = "Ganado Silvopastoril",
                    Latitud = 12.1149926,
                    Longitud = -86.23617439999998
                },
                new Productor{
                    Nombre="Jonathan Javier Areas Ortiz",
                    Departamento = "Managua",
                    Municipio = "Managua",
                    Comunidad ="La Resbalosa",
                    TipoFiit = "Ganado Silvopastoril",
                    Latitud = 12.1149926,
                    Longitud = -86.23617439999998
                }
            };
            #endregion
        }

    }
}
