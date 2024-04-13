using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_9.ClasePadre;

namespace clase_9.ClaseHijo
{
    //herencia
    internal class Playstation:ClsConsola
    {
        public string modelocontrolador {  get; set; }
        public string mostrardetallesplay()
        {
            return mostrardetalles() + "Controlador"+ modelocontrolador;

        }











    }
}
