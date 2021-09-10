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
        }
        public int stock
        {
            get
            {
                return _stock;
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
            return string.Format("Codigo: " + this.codigo + Environment.NewLine +
                "Nombre: " + this.nombre + "Precio:" + this.precio+ Environment.NewLine +
                "Stock: " + this.stock+ Environment.NewLine+"Nombre Categoria:" + this.Categoria);
        }

       
    }
}