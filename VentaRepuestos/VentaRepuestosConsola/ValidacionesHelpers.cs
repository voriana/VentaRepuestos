using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestosConsola
{
    class ValidacionesHelpers
    { 
         internal static bool NumeroPositivo(int dato)
         {
            bool flag = false;
             if (dato>0)
             {
                flag=true;
             }
            return flag;
         }

        //validar String 
        internal static string ValidarString(string algo) {
          
                if (algo.Equals(string.Empty))
                {
                    return null;
                } else
                {
                    return  algo;
                }
            
        }
        internal static double PedirDouble(string Snumero)
        {
            return Convert.ToDouble(Snumero);
        }


        internal static int PedirInt(string Snumero)
        {

            return Convert.ToInt32(Snumero);
        }

    }
}
