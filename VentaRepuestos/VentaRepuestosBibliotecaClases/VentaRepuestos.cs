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


        public bool AgregarRepuesto(Repuesto repuesto)
        {
            //bool flag;
            if (repuesto is null)
            {
                return false;
            }
            else
            {
                return true;
            }
              
        }
    }
}
