using System;
using System.Collections.Generic;
using static Ejercicio5.Coche;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string matricula = string.Empty ;
            int opcion = 0;
            List<Coche> listaCoche = new List<Coche>();
            Coche coche = new Coche();
            TipoEtiqueta etiqueta;
            bool salir ;


            coche.mostrarDatos();
            Console.WriteLine("");
            opcion = Convert.ToInt32(Console.ReadLine());

            salir = (opcion == 6) ? true:false;

            while (salir == false)
            {
               
                switch (opcion)
                {
                    case 0:
                        salir = true;
                        Console.WriteLine("Hasta pronto! ");
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        
                        Console.WriteLine("Introduce matrícula");
                        matricula = Console.ReadLine();
                        etiqueta = coche.elegirEtiqueta(opcion);
                        coche.operacionEtiqueta(opcion, etiqueta);
                        listaCoche.Add(new Coche(matricula, etiqueta));
                        break;
                    default:
                        Console.WriteLine("No existe esa opción ");
                        break;

                }
                if (opcion != 0)
                {
                    coche.mostrarDatos();
                    Console.WriteLine("");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
            }






        }
    }
}
