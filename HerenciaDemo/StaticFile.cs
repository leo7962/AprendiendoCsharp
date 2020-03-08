namespace HerenciaDemo
{
    internal class StaticFile : MultimediaFile
    {
        ////public StaticFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento) //: base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        ////{

        ////}

        //public override void DesplegarInfo()
        //{
        //    Console.WriteLine("Soy un archivo estatico");
        //}

        //public virtual void Editar()
        //{
        //    Console.WriteLine("Editando");
        //}
        public override string obtenerTipo()
        {
            return "archivo estatico";
        }
    }
}
