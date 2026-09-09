using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Objetos
{
    internal class AireAcondicionado
    {
        public string marca;
        public string modelo;
        public string color;
        public int voltaje;
        public int btu;
        public int temperatura;

        public void SubirTemperatura()
        {
            temperatura ++;
        }

        public void bajarTemperatura()
        {
            temperatura--;
        }

        public int darTemperatura()
        {
            return temperatura; 
        }
    }
}
