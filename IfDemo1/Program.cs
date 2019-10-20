using System;

namespace IfDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////variables booleanas
            //bool mayorEdad = false;
            //Console.WriteLine(mayorEdad);

            ////operadores boleanos NOT
            //mayorEdad = !false;
            //Console.WriteLine(mayorEdad);

            ////operadores boleanos Igualdad == y desigualdad o relacionales
            //bool esIgual = 42 == 42;
            //Console.WriteLine(esIgual);

            ////operador de desigualdad !=
            //bool esIgual2 = 42 != 42;
            //Console.WriteLine(esIgual2);

            //esIgual2 = 42 != 43;
            //Console.WriteLine(esIgual2);

            //int numero1 = 100;
            //int numero2 = 100;
            //bool esigual3 = numero1 == numero2;
            //Console.WriteLine(esigual3);

            //operadores relacionales < > <= >=
            int edad = 30;
            bool resultado = edad <= 30;
            Console.WriteLine(resultado);

            bool resultado2 = edad >= 20;
            Console.WriteLine(resultado2);

            //operadores lógicos AND && y OR ||
            bool logico = (3 == 3) && (4 == 4) && (5 == 5);
            Console.WriteLine(logico);

            //or
            bool logico2 = (3 == 4) || (4 == 4);
            Console.WriteLine(logico2);

            Console.ReadLine();
        }
    }
}
