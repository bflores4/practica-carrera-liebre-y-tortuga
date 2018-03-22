using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_carrera_liebre_y_tortuga
{
    class Tortuga:Corredor
    {
        public string avanzar()
        {
            string quePaso = "";
            int pasos = r.Next(1, 11);

            if (pasos > 0 && pasos < 6)
            {
                _pasosAvanzados += 3;
                quePaso = "La tortuga dio un paso rapido (+3), se encuentra en el paso " + _pasosAvanzados + Environment.NewLine;
            }
            else if (pasos > 5 && pasos < 8)
            {
                _pasosAvanzados -= 6;
                quePaso = "La tortuga dio un resbalon (-6), se encuentra en el paso " + _pasosAvanzados + Environment.NewLine;
            } 
            else
            {
                _pasosAvanzados += 1;
                quePaso = "La tortuga dio un paso lento (+1), se encuentra en el paso " + _pasosAvanzados + Environment.NewLine;
            }
            return quePaso;
        }
    }
}
