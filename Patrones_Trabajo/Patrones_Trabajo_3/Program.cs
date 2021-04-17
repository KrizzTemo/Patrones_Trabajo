using System;
using Patrones_Trabajo_3.CFacade;

namespace Patrones_Trabajo_3
{
    class Program
    {
        static void Main()
        {

            Console.Title = " Patron estructural - Facade Pattern ";

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Magenta;

            Facade Cliente1 = new Facade();

            Cliente1.Buscar("17-04-2021","24-04-2021","Lisboa","Portugal");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Facade Cliente2 = new Facade();

            Cliente2.Buscar("18-04-2021","25-04-2021","Paris","Francia");

            Console.ReadKey();

        }
    }
}
