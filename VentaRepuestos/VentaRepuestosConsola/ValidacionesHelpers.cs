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
             if (dato>=0)
             {
                flag=true;
             }
            return flag;
         }

        internal static bool NumeroPositivo(double dato)
        {
            bool flag = false;
            if (dato > 0)
            {
                flag = true;
            }
            return flag;
        }

        //pedir string
        internal static string SolicitarString(string dato)
        {
            string Esvalido="";
            bool flag= false;
            while (!flag)
            {
                Console.WriteLine("Ingrese " + dato + ":");
                Esvalido = Console.ReadLine();
                if (Esvalido.Equals(string.Empty))
                {
                    Esvalido = "";
                }
                else
                {
                    flag = true;
                }

            }
            return Esvalido;
     
        }

        internal static double PedirDouble(string Snumero)
        {
            double resultado=0;
            bool flag=false;
            
            while (!flag)
            {
                Console.WriteLine("Ingrese " + Snumero+":");
                string ingreso = Console.ReadLine();
                flag = double.TryParse(ingreso, out resultado);
                if (!flag)
                {
                    Console.WriteLine("Dato invalido.");
                }
                else if(ValidacionesHelpers.NumeroPositivo(resultado))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor positivo");
                    flag = false;
                }

            }
            return resultado;
        }


        internal static int PedirInt(string dato)
        {
            int resultado = 0;
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Ingrese "+ dato+":");
                string ingreso = Console.ReadLine();
                flag=int.TryParse(ingreso, out resultado);

                if (!flag)
                {
                    Console.WriteLine("Dato erroneo. Debe ingresar un valor numerico");
                }
                else if (ValidacionesHelpers.NumeroPositivo(resultado))
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor positivo");
                    flag = false;
                }
            }
            
            return resultado;
        }

    }
}
