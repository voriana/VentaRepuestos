using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestosBibliotecaClases;

namespace VentaRepuestosConsola
{
    class Program
    {
        static bool _consolaActiva;
        static VentaRepuestos _tiendaRepuestos;

        static Program()
        {
            _consolaActiva = true;
            _tiendaRepuestos = new VentaRepuestos();
        
        }
    

        static void Main(string[] args)
        {
            int opcion;
            while (_consolaActiva)
            {
                DesplegarMenu();
                opcion = ValidacionesHelpers.SolicitarInt();
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;

                }
            }

        }

        static void DesplegarMenu()
        {
            Console.WriteLine("******* BIENVENIDOS *******");
            Console.WriteLine("Ingrese una de las siguientes opciones para empezar el programa");
            Console.WriteLine("1- Agregar respuesto");
            Console.WriteLine("2- Quitar repuesto");
            Console.WriteLine("3- Modificar precio");
            Console.WriteLine("4- Agregar stock");
            Console.WriteLine("5- Quitar stock");
            Console.WriteLine("6- Traer por categoria");

        }

        private void NuevoRepuesto()
        {
            SolicitarString("Nombre");
            string nombre = ValidacionesHelpers.ValidarString();

        }

        internal static void SolicitarString(string dato)
        {
            Console.WriteLine("Ingrese " + dato);
        }
    }
}
