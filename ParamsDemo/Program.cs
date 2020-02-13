using System;

namespace ParamsDemo
{
    internal class Program
    {
        //no se puede usar en arreglos multidimensionales, ni se puede sobrecargar sus metodos u operadores 
        //debe ser el último parametro en una lista de parametros formales
        //tiene prioridad sobre otras funciones
        private static void Main(string[] args)
        {
            int suma = Sumar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10000, "1.23");

            Console.WriteLine(suma);
        }

        private static int Sumar(params object[] numeros)
        {
            //if (numeros.Length < 2 || numeros == null)
            //{
            //    throw new ArgumentException("Debe agregar dos parametros como minimo");
            //}
            //else
            //{
            //    int suma = 0;
            //    foreach (var numero in numeros)
            //    {
            //        suma += numero;
            //    }

            //    return suma;
            //}

            int suma = 0;
            foreach (object numero in numeros)
            {
                if (numero is int)
                {
                    suma += (int)numero;
                }
                else if (numero is string)
                {
                    bool convertido =
                        int.TryParse((string)numero, out int temporal);
                    if (convertido)
                    {
                        suma += temporal;
                    }
                    else
                    {
                        throw new Exception("valor no numérico");
                    }
                }
                else
                {
                    throw new Exception("Valor no númerico");
                }
            }

            return suma;
        }
    }
}
