using System;

namespace OperadoresAsignacionCompuestos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int variable = 50;
            //Console.WriteLine(variable + 30);

            //variable = 10;
            //variable++;
            //variable--;
            //variable = variable + 40;

            //variable %= 40;

            var texto = "Soy un programador";
            Console.WriteLine(texto);
            texto += "de C#";
            Console.WriteLine(texto);
            var texto2 = " Y .NET";
            texto += texto2;
            Console.WriteLine(texto);


            //Console.WriteLine(variable);
        }
    }
}