namespace HerenciaDemo
{
    internal static class MetodosExtension
    {
        public static int ContarPalabras(this string cadena, char caracter)
        {
            //Hola mundo = [hola], [mundo]
            string[] palabras = cadena.Split(caracter);
            return palabras.Length;
        }
    }
}
