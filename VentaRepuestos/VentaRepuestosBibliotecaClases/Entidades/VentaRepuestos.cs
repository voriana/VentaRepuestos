using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosBibliotecaClases.Entidades
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

        //propiedades
        public string nombre
        {
            get
            {
                return _nombreComercio;
            }
        }
        
        public string direccion
        {
            get
            {
                return _direccion;
            }
        }

        public List<Repuesto> lista
        {
            get
            {
                return _listaProductos;
            }
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
                        if (repues.stock > 0)
                        {
                            flag = false;
                        }
                        else
                        {
                            _listaProductos.Remove(repues);
                            break;
                        }
                    }
                    
                }
               
            }
            return flag;
        }

        public int ObtenerMaxCodigo()
        {
            int resultado=0;
            if (_listaProductos.Count() == 0)
            {
                resultado = 1;
            }
            else
            {
                resultado = _listaProductos.Count()+1;
            }
            return resultado;
            
        }

        public bool ModificarPrecio(int cod, double Nprecio)
        {
            bool flag = false;

           foreach(Repuesto item in _listaProductos)
           {
                if (item.codigo == cod)
                {
                    item.precio = Nprecio;
                    flag = true;
                }
                
           }
            return flag;
        }

        public bool AgregarStock(int cod, int cant)
        {
            bool flag = false;
            foreach(Repuesto r in _listaProductos)
            {
                if(r.codigo== cod)
                {
                    r.stock += cant;
                    flag= true;
                }
            }
            return flag;
        }

        public bool QuitarStock(int cod, int cant)
        {
            bool flag = false;
            foreach (Repuesto r in _listaProductos)
            {
                if (r.codigo == cod)
                {
                    r.stock -= cant;
                    flag = true;
                }
            }
            return flag;
        }

        public List<Repuesto> RepuestosPorCategoria(int codigo)
        {
            List<Repuesto> repuestos = new List<Repuesto>();
            foreach (Repuesto item in _listaProductos)
            {
                if (item.Categoria.codigo==codigo)
                {
                    repuestos.Add(item);
                }
            }
            return repuestos;
        }

        public Repuesto BuscarPorCod(int cod)
        {
            Repuesto m = new Repuesto();
            foreach(Repuesto r in _listaProductos)
            {
                if (r.codigo == cod)
                {
                    m = r;
                }
            }
            return m;
        }

    }
}
