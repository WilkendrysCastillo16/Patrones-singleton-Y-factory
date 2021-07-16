using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Programacion_2
{
    class FABRICA
    {
        public static IEMPLEADOS GetIEMPLEADOS(int N)
        {

             if (N == 2)
            {
                return new ADMINISTRACTIVO();
            }
             else if (N == 3)
             {
                 return new OPERATIVO();
             }
            else
            {
                return null; 
            }

        }
    }
}
