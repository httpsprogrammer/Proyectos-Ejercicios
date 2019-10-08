using ExcelDataReader;
using System;
using System.IO;

namespace ImportarExtrayendoRuta
{
    class Program
    {
       static string ruta; 
        static void Main(string[] args)
        {

            ruta = getPathExcel();//Método creado para recoger la ruta de un directorio
            extraerDatosExcel(ruta);
            Console.Write("");


        }

        //Extrae la ruta donde se encuentra el archivo
        public static string getPathExcel()
        {
            int pos;
            string path;
            path = AppDomain.CurrentDomain.BaseDirectory;//Recoge el path hasta la carpeta bin del proyecto
            pos = path.IndexOf("ImportarExcel") < 1 ? 0 : path.IndexOf("ImportarExcel");//Extraigo parte de la ruta que no necesito
            path = pos < 1 ? "" : path.Remove(pos);//Recojo la posición y elimino la parte de la ruta que no necesito

            return path += @"ImportarExcel\ImportarExtrayendoRuta\Excel\";//Agrego la ruta en la que se encuentra el archivo
        }

        private static void extraerDatosExcel(string ruta)
        {
            ruta += "MiExcel.xlsx";
            //Se necesitan importar los paquetes nugets de ExcelDataReader y System.Text.Encoding.CodePage
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(ruta, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {

                        while (reader.Read())
                        {
                            Console.WriteLine("Col1:" + reader.GetValue(0).ToString());//Columna1
                            Console.WriteLine("Col2" + reader.GetValue(1).ToString());//Columna2

                        }
                    } while (reader.NextResult());
                }
            }

          
        }
    }
}
