using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestosBibliotecaClases.Entidades;
using VentaRepuestosBibliotecaClases.Utilidades;

namespace VentaRepuestosConsola
{
    class Program
    {
        static bool _consolaActiva;
        static VentaRepuestos _tiendaRepuestos;

        static Program()
        {
            _consolaActiva = true;
            _tiendaRepuestos = new VentaRepuestos("Cayetano", "White 210");
            CategoriaHelpers.ListaCategorias();

        }
    

        static void Main(string[] args)
        {
            
            int opcion;
            Console.WriteLine($"Venta de repuestos {_tiendaRepuestos.nombre.ToUpper()}");
            while (_consolaActiva)
            {
                DesplegarMenu();
                opcion = ValidacionesHelpers.PedirInt("Opcion que desea realizar");
               
                switch (opcion)
                {
                        case 1:
                            NuevoRepuesto();
                            break;
                        case 2:
                            EliminarRepuesto();
                            break;
                        case 3:
                            ModificaPrecio();
                            break;
                        case 4:
                            AgregaStock();
                            break;
                        case 5:
                            QuitaStock();
                            break;
                        case 6:
                            RepuestosPorCategoria();
                            break;
                        case 7:
                            _consolaActiva = false;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    
                }
            }

        }

        static void DesplegarMenu()
        {
            Console.WriteLine("******* Menu *******");
            Console.WriteLine("1- Agregar respuesto");
            Console.WriteLine("2- Quitar repuesto");
            Console.WriteLine("3- Modificar precio");
            Console.WriteLine("4- Agregar stock");
            Console.WriteLine("5- Quitar stock");
            Console.WriteLine("6- Traer por repuestos por categoria");
            Console.WriteLine("7- Para Salir");

        }

        private static void NuevoRepuesto()
        {
            int codigo;
            string nombre;
            double precio;
            int stock;
            int codCategoria;

            codigo = _tiendaRepuestos.ObtenerMaxCodigo();
            nombre = ValidacionesHelpers.SolicitarString("nombre");
            precio = ValidacionesHelpers.PedirDouble("precio");
            stock = ValidacionesHelpers.PedirInt("stock");
            Console.WriteLine("***Categorias***");
            
            foreach (Categoria c in CategoriaHelpers.Categorias())
            {
                Console.WriteLine("Categoria--> "+c);
            }

            codCategoria = ValidacionesHelpers.PedirInt("codigo de categoria");
            Categoria ca = CategoriaHelpers.CategoriaPorCod(codCategoria);

            Repuesto rep = new Repuesto(codigo,nombre, precio, stock,ca);

            if (_tiendaRepuestos.AgregarRepuesto(rep))
            {
                Console.WriteLine($"El repuesto agregado es:\n {rep.ToString()}");
            }
            else
            {
                Console.WriteLine("No se pudo agregar repuesto.");
            }
            

            


        }
      
        private static void EliminarRepuesto()
        {

            foreach(Repuesto r in _tiendaRepuestos.lista)
            {
                Console.WriteLine($"---Lista repuestos---\n{r.ToString()}");
            }
            int codigo = ValidacionesHelpers.PedirInt("codigo repuesto a eliminar");
            Console.WriteLine($"Se elminara el repuesto {_tiendaRepuestos.BuscarPorCod(codigo).ToString()}");
            if (_tiendaRepuestos.QuitarRepuesto(codigo))
            {
                Repuesto elimando = _tiendaRepuestos.BuscarPorCod(codigo);
                Console.WriteLine($"Se ha eliminado el repuesto ");
            }
            else
            {
                Console.WriteLine("Aun tiene Stock");
            }
        }

        private static void ModificaPrecio()
        {
            int codigo = ValidacionesHelpers.PedirInt("codigo repuesto, que desea modificar su precio");
            double nuevo=ValidacionesHelpers.PedirDouble(" ingrese nuevo precio");

            if (_tiendaRepuestos.ModificarPrecio(codigo, nuevo))
            {
                Console.WriteLine($"Se ha modificado el precio de\n {_tiendaRepuestos.BuscarPorCod(codigo).ToString()}");
            }
            else
            {
                Console.WriteLine("No existe repuesto para el codigo ingresado");
            }
        }

        private static void AgregaStock()
        {
            int codigo = ValidacionesHelpers.PedirInt("codigo de repuesto");
            int cantidad = ValidacionesHelpers.PedirInt("Ingrese cantidad de stock");
            
            if(_tiendaRepuestos.AgregarStock(codigo, cantidad))
            {
                Console.WriteLine($"Se agrega Stock al repuesto: {_tiendaRepuestos.BuscarPorCod(codigo).nombre} ");
            }
            else
            {
                Console.WriteLine("No existe el codigo de repuesto ingresado");
            }
        }

        private static void QuitaStock()
        {
            int codigo = ValidacionesHelpers.PedirInt("codigo de repuesto");
            int cantidad = ValidacionesHelpers.PedirInt("Ingrese cantidad de stock");

            if (_tiendaRepuestos.QuitarStock(codigo, cantidad))
            {
                Console.WriteLine("Se  Stock disminuido ");
            }
            else
            {
                Console.WriteLine("No existe el codigo de repuesto ingresado");
            }
        }

        private static void RepuestosPorCategoria()
        {
             int codCategoria = ValidacionesHelpers.PedirInt("codigo de categoria");
            List<Repuesto> repuestosPorCag = _tiendaRepuestos.RepuestosPorCategoria(codCategoria);
            foreach(Repuesto r in repuestosPorCag)
            {
                Console.WriteLine(r.ToString());
            }
        }



    }
}
