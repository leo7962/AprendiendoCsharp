using System;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //do, enunciados a ejecutar y while(expresión booleana);

            do
            {
                Console.WriteLine("Hola Leo");
            } while (8>10);

            int i = 1;
            var suma = 0;
            do
            {
                suma += i;
                i++;
            } while (i<=10);
            Console.WriteLine(suma);
        }
    }
}
