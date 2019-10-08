using ExcelDataReader;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Text.Encoding;//.RegisterProvider;(System.Text.CodePagesEncodingProvider.Instance);

namespace ImportarExcel
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();
            List<string> lista2 = new List<string>();
            
            string ruta = "C:/Users/Lenovo/Documents/Proyectos/Excel/Moneda.xlsx";

            /*Agregar paquete nuget si hiciera falta-> System.Text.Encoding.CodePages */
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
           using (var stream = File.Open(ruta, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            lista1.Add(reader.GetValue(0).ToString());
                            lista2.Add(reader.GetValue(1).ToString());
                            
                           // Console.WriteLine(reader.GetValue(1).ToString());

                        }
                    } while (reader.NextResult());
                   // Console.WriteLine(reader.GetValue(1));
                }
            }

            foreach (var i in lista1)
            {
                Console.WriteLine(i);
            }
            foreach (var i in lista2)
            {
                Console.WriteLine(i);
            }



        }
    }
}
