namespace HerenciaDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MultimediaFile mFile = new MultimediaFile();
            mFile.DesplegarInfo();

            DynamicFile dFile = new DynamicFile();
            dFile.Reproducir();

            StaticFile sFile = new StaticFile();
            sFile.Editar();
        }
    }
}
