using System;

namespace Delegados
{
    class Program
    {
        delegate  void DelegadoMostrar();

        delegate string DelegateConvertToString(int n);

        delegate void DelegadoEscuchar();
        static void Main(string[] args)
        {
            var mostrar = new DelegadoMostrar(MostrarMensaje);
            var path = new DelegateConvertToString(getNum);

            //DelegadoEscuchar escuchar = new DelegadoEscuchar(Radio.escucharRadio);
            var escuchar = new DelegadoEscuchar(Radio.escucharRadio);
             

            mostrar();
            Console.WriteLine(path(10));
            escuchar();
            escuchar = new DelegadoEscuchar(Concierto.escucharConcierto);//Puedo cambiar la referencia 
            escuchar();
        }

        public static string getNum(int n) {
            return n.ToString();
        }
        private static void MostrarMensaje()
        {
            Console.WriteLine("Mostrando un mensaje mediante un delegado ");
        }
    }
}
