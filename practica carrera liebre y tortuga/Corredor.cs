using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_carrera_liebre_y_tortuga
{
    abstract class Corredor
    {
        protected int _pasosAvanzados;
        protected static Random r = new Random();
         
        public int pasosAvanzados
        {
            get { return _pasosAvanzados; }
        }

        public Corredor()
        {
            _pasosAvanzados = 0; 
        }
    }
}
