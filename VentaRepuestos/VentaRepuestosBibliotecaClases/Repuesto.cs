using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosBibliotecaClases
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public Repuesto(int codigo, string nombre, double precio, int stock)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = new Categoria();
        }

        public int codigo
        {
            get
            {
                return _codigo;
            }
        }
        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }
        }
    }
}