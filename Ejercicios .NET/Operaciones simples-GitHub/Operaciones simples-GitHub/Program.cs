using System;

namespace Operaciones_simples_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[2];
            int[] edad =  new int[2];
            int valor1 = 0, valor2 =0;/*Inicializamos las variables*/
            float resultado = 0;
            
            Console.WriteLine("Introduce los datos de 2 personas ");

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Nombre: ");
                nombre[i] = Console.ReadLine();

                Console.Write("Edad: ");
                /*Convertimos a entero el valor que recogemos del usuario,
                 * Esto podría dar un error si el usuario introduce un 'string',pero,
                 * podemos usar 'try' para manejar errores
                 */
                edad[i] = Convert.ToInt32(Console.ReadLine());


                Console.Write("Introduce el primer valor: " );
                valor1 = Convert.ToInt32(Console.ReadLine()); 

                Console.Write("Introduce el segundo valor: ");
                valor2 = Convert.ToInt32(Console.ReadLine());

                resultado = valor1 + valor2;
                Console.WriteLine("Suma de " + valor1+ " + " + valor2 + " = " + resultado);

                resultado = valor1 * valor2;
                Console.WriteLine($"La multiplicación de {valor1} * {valor2}  = {resultado}");

                Console.WriteLine();

            }

            Console.WriteLine("Ha ingresado");
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine($"{nombre[i]} de {edad[i]} años.");
            }


        }
    }
}
