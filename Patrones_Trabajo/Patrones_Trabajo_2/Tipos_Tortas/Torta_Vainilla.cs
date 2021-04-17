using System;
using Patrones_Trabajo_2.Interfaces;

namespace Patrones_Trabajo_2.Tipos_Tortas
{
    class Torta_Vainilla : IProducto
    {

        public double Decorar(int cantidad)
        {

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <= cantidad; i++)
            {

                Console.WriteLine($" Decorando torta #{i} \n");

            }

            return 1.0 * cantidad;

        }

        public double Empacar(int cantidad)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 1; i <= cantidad; i++)
            {

                Console.WriteLine($" Empacando torta #{i} \n");

            }

            return 0.20 * cantidad;

        }

    }
}
