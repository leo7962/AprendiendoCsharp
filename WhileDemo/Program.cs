using System;

namespace WhileDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //While (expresión booleana)
            //enunciado a ejecutar
            var esCierto = true;
            while (esCierto)
            {
                Console.WriteLine("Hola Leonardo");
                esCierto = false;
            }

            var i = 1;
            var suma = 0;
            while (i <= 10)
            {
                suma += i;
                i++;
            }

            var input = string.Empty;
            while (input != "salir")
            {
                Console.WriteLine("Ejecutando");
                input = Console.ReadLine();
            }

            Console.WriteLine(suma);

            Console.ReadLine();
        }
    }
}