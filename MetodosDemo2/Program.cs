using System;

namespace MetodosDemo2
{
    internal class Program
    {
        private static string nombre = "Leonardo";

        private static void Main(string[] args)
        {
            int cociente = 0;
            int residuo = 0;

            (cociente, residuo) = Dividir(654123, 15621324);
            //Console.WriteLine(cociente);
            //Console.WriteLine(residuo);
            //forma de llamar a un método de forma conjunta
            //(int cociente, int residuo) data = Dividir(400, 50);
            //Console.WriteLine(data);

            //Saludar();
            //nombre = "Daniela";
            //Saludar();

            //multiplicar(2, 2);
            //Console.WriteLine(CalcularCuenta(100, 10, 3));
            //Console.WriteLine(CalcularCuenta(100, 10, 3,54.3));

            //escribirTexto("Leonardo");

            CalcularCuenta(402, 561, 454);

            CalcularAreaAlCuadrado(41, "Leo", 52m, true);
            int resultado = CalcularAreaAlCuadrado(41, "Leo", 52m, true);

            limpiarMetodo();

            Console.ReadLine();
        }

        private static void limpiarMetodo()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }

        private static int CalcularAreaAlCuadrado(int v1, string v2, decimal v3, bool v4)
        {
            throw new NotImplementedException();
        }

        private static void escribirTexto(string texto)
        {
            Console.WriteLine(texto);
            limpiar();

            void limpiar()
            {
                Console.ReadLine();
                Console.Clear();
                Console.Beep();
            }
        }

        private static double CalcularCuenta(double totalcuenta, double propina, int comensales,
            double estacinamiento = 0, double iva = 19)
        {
            return (totalcuenta + propina + estacinamiento) / comensales;
        }
        //static double CalcularCuenta(double totalcuenta, double propina, int comensales, double estacionamiento)
        //{
        //    return (totalcuenta + propina + estacionamiento) / comensales;
        //}

        private static int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private static float multiplicar(float numero2, int numero3)
        {
            return numero2 * numero3;
        }

        private static void Saludar()
        {
            nombre = "Juan";
            Console.WriteLine(nombre);
        }

        //retornando más de un valor con un método funcional para crear recibir mas datos
        private static (int, int) Dividir(int numero1, int numero2)
        {
            int cociente = numero1 / numero2;
            int residuo = numero1 % numero2;
            return (cociente, residuo);
        }

        private static (int, string) RegresarDatos()
        {
            return (8, "Leo");
        }
    }
}