using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WpfNumerosPrimosM1
{
    internal class FerramentasMagicas
    {
        static public Boolean VerificaNumeroPrimo(int n) { 
            
            Boolean retorno = false;

            int count = 0;
            if(n == 1)
            {
               retorno = true;
            } else {
                for (int i = 1; i <= n; i++)
                {
                    if (n % 1 == 0)
                    {
                        count++;
                    }
                }
                if (count == 2) { 
                    retorno |= true;
                }
            }
            return retorno;
        }
    }
}