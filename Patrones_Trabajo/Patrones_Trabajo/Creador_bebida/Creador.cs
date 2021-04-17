using System;
using Patrones_Trabajo.Bebida;
using Patrones_Trabajo.Tipos_bebida;

namespace Patrones_Trabajo.Creador_bebida
{
    public class Creador
    {

        public const int coca_cola = 1;

        public const int pepsi = 2;

        public static Bebida_Gaseosa CreadorBebida(int Tipo) 
        {

            switch (Tipo)
            {

                case coca_cola:
                    return new Coca_Cola();

                case pepsi:
                    return new Pepsi();
                default: return null;
            }

        }

    }
}
