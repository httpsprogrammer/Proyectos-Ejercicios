using ExcelDataReader;
using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Threading.Tasks;


namespace WPF_Sincrono_Asincrono
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ruta;
        public MainWindow()
        {
            InitializeComponent();
            
        }
      
        //Extrae la ruta donde se encuentra el archivo
        public static string getPathExcel()
        {
            int pos;
            string path;
            path = AppDomain.CurrentDomain.BaseDirectory;//Recoge el path hasta la carpeta bin del proyecto
            pos = path.IndexOf("WPF_Sincrono_Asincrono") < 1 ? 0 : path.IndexOf("WPF_Sincrono_Asincrono");//Extraigo parte de la ruta que no necesito
            path = pos < 1 ? "" : path.Remove(pos);//Recojo la posición y elimino la parte de la ruta que no necesito

            return path += @"WPF_Sincrono_Asincrono\WPF_Sincrono_Asincrono\Excel\";//Agrego la ruta en la que se encuentra el archivo
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            extraerDatosExcel(getPathExcel());

        }
        private void extraerDatosExcel(string ruta) 
        {
            string col1 = "";
            List<Producto> listaProducto = new List<Producto>();

            ruta += "Datos.xlsx";
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
                            col1 = reader.GetValue(0).ToString();
                            listaProducto.Add(new Producto(col1));
                            System.Threading.Thread.Sleep(900);

                        }
                    } while (reader.NextResult());
                }
            }

            dtGridRegistro.ItemsSource = listaProducto;

        }

        /// <summary>
        /// Método que se realizar de manera asíncrona
        /// </summary>
        /// <param name="ruta">Recoge la ruta donde se encuentra el archivo</param>
        /// <returns></returns>
        private async Task extraerDatosExcelAsync(string ruta)
        {
            string col1 = "";
            List<Producto> listaProducto = new List<Producto>();
            Task<Producto> task;

            ruta += "Datos.xlsx";
            //Se necesitan importar los paquetes nugets de ExcelDataReader y System.Text.Encoding.CodePage
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //await Task.Run(() => Sirve para realizar la ejecución asíncrona
            await Task.Run(() =>
            {
                using (var stream = File.Open(ruta, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                col1 = reader.GetValue(0).ToString();
                                listaProducto.Add(new Producto(col1));
                                System.Threading.Thread.Sleep(900);//Realiza espera durante la ejecución

                            }
                        } while (reader.NextResult());
                    }
                }
            });

            dtGridRegistro.ItemsSource = listaProducto;//Guarda la lista en un DataGrid
        }

        private  void CargarAsyn_Click(object sender, RoutedEventArgs e)
        {

            extraerDatosExcelAsync(getPathExcel());
        }
    }
}
