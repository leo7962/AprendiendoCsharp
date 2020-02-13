using System;

namespace SwitchDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int dia = 3;
            switch (dia)
            {
                case 0:
                    Console.WriteLine("Lunes");
                    break;
                case 1:
                    Console.WriteLine("Martes");
                    break;
                case 2:
                    Console.WriteLine("Miercoles");
                    break;
                case 3:
                    Console.WriteLine("Jueves");
                    break;
                case 4:
                    Console.WriteLine("Viernes");
                    break;
                case 5:
                    Console.WriteLine("Sábado");
                    break;
                case 6:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("Digite un número entre 0 a 6");
                    break;
            }

            char vocal = 'e';
            switch (vocal)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("es una vocal");
                    break;
                default:
                    Console.WriteLine("No es una vocal");
                    break;
            }
        }
    }
}