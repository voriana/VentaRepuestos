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
            _tiendaRepuestos = new VentaRepuestos("Ventas el sol", "CABA");
        
        }
    

        static void Main(string[] args)
        {
            
            int opcion;
            while (_consolaActiva)
            {
                DesplegarMenu();
                if(int.TryParse(Console.ReadLine(), out opcion))
                { 
                    switch (opcion)
                    {
                        case 1:
                            NuevoRepuesto();
                            break;
                        case 2:
                            EliminarRepuesto();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        default:
                            break;
                            
                        
                           

                    }
                }
            }

        }

        static void DesplegarMenu()
        {
            Console.WriteLine("******* BIENVENIDOS *******");
            Console.WriteLine("Ingrese una de las siguientes opciones para empezar el programa: ");
            Console.WriteLine("1- Agregar respuesto");
            Console.WriteLine("2- Quitar repuesto");
            Console.WriteLine("3- Modificar precio");
            Console.WriteLine("4- Agregar stock");
            Console.WriteLine("5- Quitar stock");
            Console.WriteLine("6- Traer por categoria");
            Console.WriteLine("X- Para Salir");

        }

        private static void NuevoRepuesto()
        {
            string nombre;
            double precio;
            int stock;

            nombre = ValidacionesHelpers.SolicitarString("nombre");
            precio = ValidacionesHelpers.PedirDouble("precio");
            stock = ValidacionesHelpers.PedirInt("stock");

            Repuesto rep = new Repuesto(nombre, precio, stock);

            rep.codigo = _tiendaRepuestos.ObtenerMaxCodigo();
            rep.Categoria.codigo = 21;
            rep.Categoria.nombre = "Estandar";
            
            if (_tiendaRepuestos.AgregarRepuesto(rep))
            {
                Console.WriteLine("Repuesto nuevo agregado.");
            }
            else
            {
                Console.WriteLine("Error al intentar agregar repuesto");
            }

        }
      
        private static void EliminarRepuesto()
        {
            
            int codigo = ValidacionesHelpers.PedirInt("codigo repuesto a eliminar");
            if (_tiendaRepuestos.QuitarRepuesto(codigo))
            {
                Console.WriteLine("Se ha eliminado el repuesto"+ _tiendaRepuestos.ToString());
            }
            else
            {
                Console.WriteLine("No existe el repuesto");
            }
        }

        

       

    }
}
