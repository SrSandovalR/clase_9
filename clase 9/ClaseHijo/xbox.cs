using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_9.ClasePadre;

namespace clase_9.ClaseHijo
{
    internal class xbox:ClsConsola
    {
        public string escuadrada {  get; set; }

        public string mostrardetallesXbox()
        {
            return "Es cuadrada?: " + escuadrada;


        }
    }
}
