using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaDemo
{
    class MultimediaFile
    {
        public string FechaCreacion;
        string FechaModificacion;
        string Nombre;
        string TipoElemento;

        public void DesplegarInfo()
        {
            string informacion = FechaCreacion + " " + FechaModificacion + " " + Nombre + " " + TipoElemento;
            Console.WriteLine(informacion);
        }
    }
}
