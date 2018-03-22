using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_carrera_liebre_y_tortuga
{
    class Liebre:Corredor
    {
        public string avanzar()
        {
            string quePaso = "";
            int pasos = r.Next(1, 11);

            if (pasos > 0 && pasos < 3)
            {
                quePaso = "La liebre se quedó dormida (+0), se encuentra en el paso " + _pasosAvanzados  + Environment.NewLine;
            }
            else if (pasos > 2 && pasos < 5)
            {
                _pasosAvanzados += 9;
                quePaso = "La liebre dio un salto grande (+9), se encuentra en el paso " + _pasosAvanzados + Environment.NewLine;
            }
            else if (pasos == 5)
            {
                _pasosAvanzados -= 12;
                quePaso = "La liebre dio un  resbalon grande (-12), se encuentra en el paso " + _pasosAvanzados + Environment.NewLine;
            }
            else if (pasos > 5 && pasos <9)
            {
                _pasosAvanzados += 1;
                quePaso = "La liebre dio un  salto pequeño (+1), se encuentra en el paso " + _pasosAvanzados  + Environment.NewLine;
            }
            else
            {
                _pasosAvanzados -= 2;
                quePaso = "La liebre dio un  resbalon pequeño (-2), se encuentra en el paso " + _pasosAvanzados + Environment.NewLine;
            }


            return quePaso;
        }
    }
}
