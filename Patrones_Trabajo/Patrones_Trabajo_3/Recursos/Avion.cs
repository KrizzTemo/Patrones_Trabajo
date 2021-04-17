using System;

namespace Patrones_Trabajo_3.Recursos
{
    class Avion
    {

        public void BuscarVuelo(string fechaIda, string fechaVuelta, string origen, string destino)
        {

            Console.WriteLine("-------------------------------|Resultado|------------------------------- \n");

            Console.WriteLine($" Vuelos encontrados para: {destino} desde: {origen} \n");

            Console.WriteLine($" Fecha Ida: {fechaIda} Fecha de vuelta: {fechaVuelta} \n");

            Console.WriteLine("-------------------------------|Resultado|------------------------------- \n");

        }

    }
}
