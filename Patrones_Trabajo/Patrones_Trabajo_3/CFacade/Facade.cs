using System;
using Patrones_Trabajo_3.Recursos;

namespace Patrones_Trabajo_3.CFacade
{
    class Facade
    {

        private readonly Avion avion;

        private readonly Hotel hotel;

        public Facade() { avion = new Avion(); hotel = new Hotel(); }

        public void Buscar(string fechaIda, string fechaVuelta, string origen, string destino)
        {

            avion.BuscarVuelo(fechaIda, fechaVuelta, origen, destino);

            hotel.BuscarHotel(fechaIda, fechaVuelta, origen, destino);

        }

    }
}
