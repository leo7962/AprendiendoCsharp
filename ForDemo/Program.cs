using System;

namespace ForDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //for (inicialización; expresión booleana; actualización de la variable de control)
            for (var i = 0; i <= 10; i++) Console.WriteLine(i);

            var suma = 0;
            for (var i = 0; i <= 10; i++) suma += i;
            Console.WriteLine(suma);

            //for (;  ; )
            //{
            //    Console.WriteLine("Soy infinito");
            //}

            for (int i = 0, j = 10; i < j; i++, j--) Console.WriteLine(j);

            Console.ReadLine();
        }
    }
}