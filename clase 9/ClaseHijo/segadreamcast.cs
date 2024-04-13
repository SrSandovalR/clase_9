using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_9.ClasePadre;

namespace clase_9.ClaseHijo
{
    internal class segadreamcast:ClsConsola
    {
        public string aniodesalida { get; set; }

        public string mostrardetallessega()
        {

            return  "anio de salida: " + aniodesalida;
        }

    }
}
