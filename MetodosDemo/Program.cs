using System;

namespace MetodosDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Daniela es mi novia y es muy linda");
            //borrarConsola();
            //Console.SetCursorPosition(40, 20);
            //borrarConsola();
            //Console.SetWindowSize(50, 50);
            //borrarConsola();
            //Console.ReadLine();
            //borrarConsola();
            //Console.Clear();
            //borrarConsola();
            //Console.Beep();
            //borrarConsola();

            //string name = Console.ReadLine();
            //saludar(name);
            int result = sumar(50, 50);
            Console.WriteLine(result / 2);

            Console.ReadLine();
        }

        private static int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private static void saludar(string name)
        {
            sumar(51, 45);
            Console.WriteLine("Hola " + name);
        }

        // tipo de dato a retornar + nombre del método + parametros
        private static void borrarConsola()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }

        //métodos con cuerpo de expesión 
        private static void Saludar()
        {
            Console.WriteLine("Hola Leo");
        }

        private static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}