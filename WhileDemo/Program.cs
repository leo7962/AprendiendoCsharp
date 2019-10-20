using System;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //While (expresión booleana)
            //enunciado a ejecutar
            bool esCierto = true;            
            while (esCierto)
            {
                Console.WriteLine("Hola Leonardo");
                esCierto = false;

            }

            int i = 1;
            int suma = 0;
            while(i <= 10)
            {
                suma += i;
                i++;
            }

            string input = string.Empty;
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
