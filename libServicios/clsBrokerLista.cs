using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios.Colecciones
{   
    public class clsBrokerLista
    {   
        public static bool sonListasIguales<Tipo>(List<Tipo> prmLista1, List<Tipo> prmLista2) 
        where Tipo : IComparable
        {
            if(prmLista1.Count == prmLista2.Count)
            {
                for(int varIndice = 0; varIndice < prmLista1.Count; varIndice++)
                {
                    if (prmLista1[varIndice].CompareTo(prmLista2[varIndice]) != 0)
                        return false;
                }
                return true;
            }
            return false;
        }
        
    }
}
