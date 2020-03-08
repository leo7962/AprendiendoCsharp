using System;

namespace HerenciaDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //MultimediaFile mFile = new MultimediaFile(/*"29/02/2020","12/12/2020","nuevo archivo multimedia", "video"*/);
            //mFile.DesplegarInfo();

            //Console.WriteLine(mFile);

            //mFile.ToString();

            //DynamicFile dFile = new DynamicFile(/*"29/02/2020", "12/12/2020", "nuevo archivo dinamico", "video"*/);
            ////dFile.Reproducir();
            //dFile.DesplegarInfo();

            //StaticFile sFile = new StaticFile(/*"29/02/2020", "12/12/2020", "nuevo archivo estatico", "video"*/);
            ////sFile.Editar();
            //sFile.DesplegarInfo();

            ////mFile.DesplegarInfo();
            ////dFile.DesplegarInfo();
            ////sFile.DesplegarInfo();

            //MultimediaFile mFile2 = sFile;
            //StaticFile sFile2 = mFile2 as StaticFile;
            //if (mFile2 != null)
            //{
            //    sFile2.DesplegarInfo();
            //}

            //Console.ReadLine();

            //MultimediaFile multimedia;
            //DynamicFile dFuke = new DynamicFile();
            //StaticFile sFile = new StaticFile();
            //OtherFile oFile = new OtherFile();

            //multimedia = dFuke;
            //Console.WriteLine(multimedia.obtenerTipo());

            //multimedia = sFile;
            //Console.WriteLine(multimedia.obtenerTipo());

            //multimedia = oFile;
            //Console.WriteLine(multimedia.obtenerTipo());

            string prueba = "Esta es una demo de los métodos de extensión";
            //var cantidad1 = MetodosExtension.ContarPalabras(prueba);

            var cantidad2 = prueba.ContarPalabras(' ');

            //Console.WriteLine(cantidad1);
            Console.WriteLine(cantidad2);

            Console.ReadLine();
        }
    }
}
