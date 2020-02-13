using System;

namespace HerenciaDemo
{
    internal class DynamicFile : MultimediaFile
    {
        private readonly string duracion;

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
