using System;

namespace Ejemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el numero de regalos a comprar para un salon
            //Sabiendo que a cada niño le toca 2 regalos
            //Y  que hay 23 niños

            //declaracion de variables
            int niños =0;
            int regalosPorNiño = 0;
            int regalosEntotal = 0;
            // lectura de variables
            niños = 23;
            regalosPorNiño = 2;
            //proceso
            regalosEntotal = niños * regalosPorNiño;
            //Salida de datos
            Console.WriteLine("regalos en total para comprar : " + regalosEntotal);
            Console.ReadKey();
        }
    }
}
