using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VentaRepuestosBibliotecaClases
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public Categoria()
        {

        }

        public Categoria(int cod, string nombre)
        {
            _codigo = cod;
            _nombre = nombre;
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
            set
            {
                _nombre = value;
            }
        }
    }

}