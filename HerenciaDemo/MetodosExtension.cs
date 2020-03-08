using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaDemo
{
    static class MetodosExtension
    {
        public static int ContarPalabras(this string cadena, char caracter)
        {
            //Hola mundo = [hola], [mundo]
            var palabras = cadena.Split(caracter);
            return palabras.Length;
        }
    }
}
