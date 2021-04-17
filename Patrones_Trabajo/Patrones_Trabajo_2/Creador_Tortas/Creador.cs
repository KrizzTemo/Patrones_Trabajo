using System;
using Patrones_Trabajo_2.Interfaces;

namespace Patrones_Trabajo_2.Creador_Tortas
{
    class Creador
    {

        public double MetodoTemplate(IProducto tipo, int cantidad)
        {

            double total = 0;

            total += CrearTorta(cantidad);

            total += tipo.Decorar(cantidad);

            Proceso();

            total += tipo.Empacar(cantidad);

            return total;

        }

        private double CrearTorta(int cantidad)
        {

            Console.WriteLine($" Creando {cantidad} tortas \n");

            return 10.20 * cantidad;

        }

        private void Proceso() => Console.WriteLine(" Pasó control de proceso \n");

    }
}
