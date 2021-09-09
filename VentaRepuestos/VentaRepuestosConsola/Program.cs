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
            int codigo = IncrementarValor(1);
            string nombre;
            double precio=0;
            string sPrecio;
            string Sstock;
            int stock=0;
            bool flag = false;

            
            nombre=SolicitarString(" nombre del repuesto: ");
            
            do
            {
                sPrecio = SolicitarString(" precio del repuesto " + nombre);
                try
                {
                    precio = ValidacionesHelpers.PedirDouble(sPrecio);
                    flag = true;
                }
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);

                }
            } while (flag == false);



            do
            {
                Sstock = SolicitarString("stock del repuesto " + nombre);
                try
                {
                    stock = ValidacionesHelpers.PedirInt(Sstock);
                    if (ValidacionesHelpers.NumeroPositivo(stock))
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero positivo");
                    }
                }
                catch(SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
                
               
            } while (flag == false);

            Repuesto rep = new Repuesto(codigo, nombre, precio, stock);
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
            string cod=SolicitarString("Ingrese codigo del repuesto a eliminar");
            int codigo = ValidacionesHelpers.PedirInt(cod);
            if (_tiendaRepuestos.QuitarRepuesto(codigo))
            {
                Console.WriteLine("Se ha eliminado el repuesto"+ _tiendaRepuestos.ToString() );
            }
            else
            {
                Console.WriteLine("No existe el repuesto");
            }
        }

        internal static  string SolicitarString(string dato)
        {
            string Esvalido;
            do
            {
                Console.WriteLine("Ingrese " + dato);
                Esvalido = Console.ReadLine();
                ValidacionesHelpers.ValidarString(Esvalido);

            } while (Esvalido=="");

            return Esvalido;
            
        }

        internal static int IncrementarValor(int cod)
        {
            return cod++;
        }

    }
}
