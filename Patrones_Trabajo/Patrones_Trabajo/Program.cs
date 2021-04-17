using System;
using Patrones_Trabajo.Bebida;
using Patrones_Trabajo.Creador_bebida;

namespace Patrones_Trabajo
{
    class Program
    {
        static void Main()
        {

            Console.Title = " Patron creacional - Factory Method ";

            Bebida_Gaseosa bd = Creador.CreadorBebida(Creador.pepsi);

            Console.WriteLine($" La cantidad de azucar de la bebida es: {bd.Cantidad_Azucar()}G ");

            Console.ReadKey();

        }
    }
}
