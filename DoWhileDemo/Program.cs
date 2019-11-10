using System;

namespace DoWhileDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //do, enunciados a ejecutar y while(expresión booleana);

            do
            {
                Console.WriteLine("Hola Leo");
            } while (8 > 10);

            var i = 1;
            var suma = 0;
            do
            {
                suma += i;
                i++;
            } while (i <= 10);

            Console.WriteLine(suma);
        }
    }
}