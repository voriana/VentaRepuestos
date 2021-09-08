using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosConsola
{
    class ValidacionesHelpers
    { 
         internal static int SolicitarInt()
         {
             return Convert.ToInt32(Console.ReadLine());
         }

        //validar String 
        internal static string ValidarString() {
            if (string.IsNullOrEmpty(Console.ReadLine()))
            {
                return null;
            }else
            {
                return Console.ReadLine();
            }
        
        }
      



    }
}
