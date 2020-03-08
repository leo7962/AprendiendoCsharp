namespace HerenciaDemo
{
    internal class MultimediaFile : object
    {
        //string FechaCreacion;
        //readonly string FechaModificacion;
        //readonly string Nombre;
        //readonly string TipoElemento;

        ////public MultimediaFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
        ////{
        ////    FechaCreacion = _fechaCreacion;
        ////    FechaModificacion = _fechaModificacion;
        ////    Nombre = _nombre;
        ////    TipoElemento = _tipoElemento;
        ////}

        //public virtual void DesplegarInfo()
        //{
        //    string informacion = FechaCreacion + " " + FechaModificacion + " " + Nombre + " " + TipoElemento;
        //    Console.WriteLine(informacion);
        //}

        //public override string ToString()
        //{
        //    return "ToString sobre escrito";
        //}

        protected string tipoArchivo;
        public virtual string obtenerTipo()
        {
            return "archivo Multimedia";
        }

        protected void CalcularTamaño()
        {

        }
    }
}
