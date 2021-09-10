using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosBibliotecaClases
{
    public class VentaRepuestos
    {

        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public VentaRepuestos()
        {

        }
        public VentaRepuestos(string comercio, string direccion)
        {
            _nombreComercio = comercio;
            _direccion = direccion;
            _listaProductos = new List<Repuesto>();
        }

        public bool AgregarRepuesto(Repuesto repuesto)
        {
            bool flag = true;

            // valido que el repuesto no este vacio 
            if (repuesto is null)
            {
                flag = false;
            }

            else 
            {   
                
                foreach (var item in _listaProductos)
                {
                    if (item.Equals(repuesto))
                    {
                        flag = false;// si existe  devuelvo false, para no agregarlo
                    break;
                    }
                }
                if (flag)// si es verdadera, es porque no lo encontro en la lista y lo agrego
                {
                    _listaProductos.Add(repuesto);
                }
                    
            }
            return flag;
              
        }

        public bool QuitarRepuesto(int codigo)
        {
            bool flag = true;
            if (_listaProductos.Count == 0)
            {
                flag = false;
                
            }
            else
            {
                foreach (var repues in _listaProductos)
                {

                    if (repues.codigo == codigo)
                    {
                         _listaProductos.Remove(repues);
                        break;
                    }
                    
                }
               
            }
            return flag;
        }

        public int ObtenerMaxCodigo()
        {
            int resultado=0;
            foreach (var item in _listaProductos)
            {
                resultado = item.codigo;
            }
            return ++resultado;
        }
    }
}
