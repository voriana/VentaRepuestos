using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosConsola
{
    class ValidacionesHelpers
    { 
         internal static bool NumeroPositivo(string dato)
         {
            bool flag = false;
             if (Convert.ToInt32(dato)>0)
             {
                flag=true;
             }
            return flag;
         }

        //validar String 
        internal static string ValidarString() {
          
                if (string.IsNullOrEmpty(Console.ReadLine()))
                {
                    return null;
                } else
                {
                    return Console.ReadLine();
                }
            
        }
        internal static double PedirDouble()
        {
            
            return Convert.ToDouble(Console.ReadLine());
        }
      



    }
}
