using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosBibliotecaClases.Entidades
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public Repuesto()
        {

        }
        public Repuesto( string nombre, double precio, int stock)
        {
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = new Categoria();
        }

        public Repuesto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = categoria;
        }

        public int codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
            
            
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
        }
        public double precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public int stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }
        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }
        }

        public override string ToString()
        {
            return "Codigo: " +this.codigo + Environment.NewLine +
                "Nombre: " + this.nombre + Environment.NewLine+ "Precio:" + this.precio+ Environment.NewLine +
                "Stock: " + this.stock+ Environment.NewLine+"Categoria\n" + Categoria;
        }

       
    }
}