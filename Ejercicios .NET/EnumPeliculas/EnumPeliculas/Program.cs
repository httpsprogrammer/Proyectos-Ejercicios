using System;

namespace EnumPeliculas
{
    class Program
    {
        //enum CapitanAmeria { Estreno = 1999 }
        enum listaMarvel { CapitanAmeria = 1999, IronMan, IronMan2,Thor, DoctorStrange}
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("1.Capitan America");
            Console.WriteLine("2.Iron Man");
            Console.WriteLine("3.Iron Man 2");
            Console.WriteLine("4.Thor");
            Console.WriteLine("5.Doctor Strange");


            switch (opcion)
            {
                case 0:
                    Console.WriteLine($"Estreno: {(int)listaMarvel.CapitanAmeria}");
                    break;
                case 1:
                    Console.WriteLine("Green");
                    break;
                case 2:
                    Console.WriteLine("Blue");
                    break;
                default:
                    Console.WriteLine("Unknown color");
                    break;
            }
        }
    }
}
