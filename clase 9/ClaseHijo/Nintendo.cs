using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_9.ClasePadre;

namespace clase_9.ClaseHijo
{
    //herencia
    internal class Nintendo:ClsConsola
    {

        public bool esPortable {  get; set; }

        public string MostrardetallesNintendo()
        {
            string detallepadre = mostrardetalles();
            return detallepadre + "Es portable:" + esPortable;


        }











    }
}
