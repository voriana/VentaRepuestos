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
            string nombre="";
            double precio = 0;
            int stock=0;

            bool flag = false;
            do
            {
                 SolicitarString(" nombre del repuesto: ");
                 nombre = ValidacionesHelpers.ValidarString();
                      
                do
                {
                    SolicitarString(" Ingrese precio del repuesto " + nombre);

                    try
                    {
                        precio = ValidacionesHelpers.PedirDouble();
                        flag = true;
                    }
                    catch (SystemException e)
                    {
                        Console.WriteLine(e.Message);
                        flag = false;
                    }

                } while (flag ==false);

                SolicitarString("stock del repuesto " + nombre);
                 string Sstock = Console.ReadLine();

                if (ValidacionesHelpers.NumeroPositivo(Sstock))
                {
                    stock = Convert.ToInt32(Sstock);

                } else
                {
                    Console.WriteLine("Debe ingresa un numero positivo");
                }


            } while (flag == false) ;

                Repuesto rep = new Repuesto(codigo, nombre, 456.70f, stock);

                if (_tiendaRepuestos.AgregarRepuesto(rep))
                {
                    Console.WriteLine("Repuesto nuevo agregado");
                }
                else
                {
                    Console.WriteLine("Error al intentar agregar repuesto");
                }




        }
      
        private static void EliminarRepuesto()
        {
            Console.WriteLine("Ingrese codigo del repuesto a eliminar");
            int codigo = Convert.ToInt32(Console.ReadLine());
            if (_tiendaRepuestos.QuitarRepuesto(codigo))
            {
                Console.WriteLine("Se ha eliminado el repuesto"+ _tiendaRepuestos.ToString() );
            }
            else
            {
                Console.WriteLine("No existe el repuesto");
            }
        }

        internal static void SolicitarString(string dato)
        {
            Console.WriteLine("Ingrese " + dato);
        }

        internal static int IncrementarValor(int cod)
        {
            return cod++;
        }

        internal static void SolicitarNum(double num)
        {
            SolicitarString(Convert.ToString(num));
        }
    }
}
