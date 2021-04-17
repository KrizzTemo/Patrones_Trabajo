using System;
using Patrones_Trabajo_2.Interfaces;
using Patrones_Trabajo_2.Tipos_Tortas;
using Patrones_Trabajo_2.Creador_Tortas;

namespace Patrones_Trabajo_2
{
    class Program
    {
        static void Main()
        {

            Console.Title = " Patron de comportamiento - Template Method ";

            IProducto proceso = null;

            double total = 0;

            Console.Write(" Ingrese tipo de torta \n 1- Chocolate \n 2- Vainilla \n :");
            string tipo = Console.ReadLine();

            #region Validacion
            if (tipo.Equals("1"))
            {

                proceso = new Torta_Chocolate();

            }
            else if (tipo.Equals("2"))
            {

                proceso = new Torta_Vainilla();

            }
            else
            {

                Console.WriteLine(" No se encontró la torta deseada ");

                return;

            }
            #endregion

            Console.Write(" Cuantas tortas desea: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Creador PD = new Creador();

            total = PD.MetodoTemplate(proceso, cantidad);

            Console.WriteLine($" El total a pagar es: {total} \n");

            Console.ReadKey();

        }
    }
}
