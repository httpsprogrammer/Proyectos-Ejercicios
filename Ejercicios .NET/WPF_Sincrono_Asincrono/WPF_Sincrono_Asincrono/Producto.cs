using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_Sincrono_Asincrono
{
    public class Producto 
    {
        public string Nombre { get; set; }

        public Producto(string nombre) {
            Nombre = nombre;
        }

    }
}
