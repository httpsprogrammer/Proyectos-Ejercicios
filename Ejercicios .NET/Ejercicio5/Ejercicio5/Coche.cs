using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Coche
    {
        public enum TipoEtiqueta { SinEtiqueta = 25, EtiquetaB = 15, EtiquetaC = 10, EtiquetaECO = 5, EtiquetaCERO  };
        TipoEtiqueta tipoEtiqueta;
        public string Matricula { get; set; }
        public double Precio = 1000 ;

        public Coche() { }
        public Coche(string matricula,TipoEtiqueta etiqueta)
        {
            
            Matricula = matricula;
            tipoEtiqueta = etiqueta;

        }


        public TipoEtiqueta elegirEtiqueta(int n)
        {
            TipoEtiqueta etiqueta = TipoEtiqueta.SinEtiqueta;/*Por defecto*/

            switch (n)
            {
                case 1:
                    etiqueta = TipoEtiqueta.SinEtiqueta;
                    break;
                case 2:
                    etiqueta = TipoEtiqueta.EtiquetaB;
                    break;
                case 3:
                    etiqueta = TipoEtiqueta.EtiquetaC;
                    break;
                case 4:
                    etiqueta = TipoEtiqueta.EtiquetaECO;
                    break;
                default:
                    etiqueta = TipoEtiqueta.EtiquetaCERO;
                    break;
            }
            return etiqueta;
        }

        public void  operacionEtiqueta(int n, TipoEtiqueta etiqueta) {
            double resultado = 0;
            double porcentaje = 0;
            
            switch (n)
            {
                case 1:
                    porcentaje = (int)etiqueta;
                    porcentaje = porcentaje / 100;
                    resultado = this.Precio +  porcentaje * this.Precio;
                    break;
                case 2:
                    porcentaje = (int)etiqueta;
                    porcentaje = porcentaje / 100;
                    resultado = this.Precio + porcentaje * this.Precio;
                    break;
                case 3:
                    porcentaje = (int)etiqueta;
                    porcentaje = porcentaje / 100;
                    resultado = this.Precio + porcentaje * this.Precio;
                    break;
                case 4:
                    porcentaje = (int)etiqueta;
                    porcentaje = porcentaje / 100;
                    resultado = this.Precio + porcentaje * this.Precio;
                    break;
                case 5:
                    resultado = Precio;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Resultado {resultado}");

        }

        public void mostrarDatos() {
            Console.WriteLine("Introduce una opción: ");
            Console.WriteLine("0..................Salir");
            Console.WriteLine("1.Sin etiqueta.....25%");
            Console.WriteLine("2.Etiqueta B.......15%");
            Console.WriteLine("3.Etiqueta C.......10%");
            Console.WriteLine("4.Etiqueta ECO.......5%");
            Console.WriteLine("5.Etiqueta CERO......0%");
        }
    }
}
