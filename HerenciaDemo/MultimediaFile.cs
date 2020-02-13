using System;

namespace HerenciaDemo
{
    internal class MultimediaFile
    {
        public string FechaCreacion;
        private readonly string FechaModificacion;
        private readonly string Nombre;
        private readonly string TipoElemento;

        public void DesplegarInfo()
        {
            string informacion = FechaCreacion + " " + FechaModificacion + " " + Nombre + " " + TipoElemento;
            Console.WriteLine(informacion);
        }
    }
}
