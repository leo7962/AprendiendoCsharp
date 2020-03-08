namespace HerenciaDemo
{
    internal class DynamicFile : MultimediaFile
    {
        //private readonly string duracion;

        ////public DynamicFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento) //: base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        ////{

        ////}

        ////public DynamicFile(string _nombre)
        ////{

        ////}
        //public override void DesplegarInfo()
        //{
        //    Console.WriteLine("Soy un archivo dinamico");
        //}

        //public virtual void Reproducir()
        //{
        //    Console.WriteLine("Reproduciendo");
        //}

        //public virtual void Pausar()
        //{
        //    Console.WriteLine("Pausa");
        //}

        //public virtual void Detener()
        //{
        //    Console.WriteLine("Detener");
        //}

        public override string obtenerTipo()
        {
            CalcularTamaño();
            string tArchivo = tipoArchivo;
            //string.ContarPalabras();
            return "Archivo Dinamico";
        }
    }
}
