using System;
using System.Text;

namespace EjercicioEnumProyecto
{
    enum Edad { Nino = 5, Menor = 15, Adulto, Mayor = 90}
    class Program
    {
        static void Main(string[] args)
        {
            int edad  = 0;
            Console.OutputEncoding = Encoding.UTF8;/*Permite mostrar caracteres especiales por consola*/

            Console.Write("Ingrese su edad: ");
            
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tu edad es {edad} ");

            if (edad < (int)Edad.Nino)
            {
                Console.WriteLine("No puede ingresar");
            }
            else {
                if (edad < (int)Edad.Menor)
                {
                    Console.WriteLine("No tiene que pagar");
                }
                else {
                    if (edad < (int)Edad.Mayor)
                    {
                        Console.WriteLine("El precio es 1 € ");
                    }
                    else {
                        Console.WriteLine("Es muy mayor ");

                    }
                }
            }

        }
    }
}
