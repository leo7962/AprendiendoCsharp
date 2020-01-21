using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaDemo
{
    class DynamicFile : MultimediaFile
    {
        string duracion;

        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausa");
        }

        public void Detener()
        {
            Console.WriteLine("Detener");
        }
    }
}
