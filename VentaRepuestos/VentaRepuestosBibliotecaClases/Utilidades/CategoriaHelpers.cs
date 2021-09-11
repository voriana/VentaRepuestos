using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestosBibliotecaClases.Entidades;

namespace VentaRepuestosBibliotecaClases.Utilidades
{
    public static class CategoriaHelpers
    {
        private static List<Categoria> _lista = new List<Categoria>();

      
        public static void ListaCategorias()
        {
            
            Categoria cat1 = new Categoria(2, "Destornillador");
            Categoria cat2 = new Categoria(11, "Automotor");
            Categoria cat3 = new Categoria(90, "Electricos");

            
            _lista.Add(cat1);
            _lista.Add(cat2);
            _lista.Add(cat3);

        }   
        public static List<Categoria> Categorias()
        {
            return _lista;
        }
         
        //Obtener categoria por codigo
         public static Categoria CategoriaPorCod(int cod)
        {
            Categoria categoria=null;

            foreach(Categoria c in _lista)
            {
                if (c.codigo == cod)
                {
                    categoria = c;
                }
            }
            return categoria;
        }

    }
}
