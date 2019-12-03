using System;

namespace ArreglosDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length >0)
            //{
            //    foreach (var parametro in args)
            //    {
            //        Console.WriteLine(parametro);
            //    }
            //}
            //var cadenas = new[] {2,4,5,4.5,465};

            //var personas = new[]
            //{
            //    new {Nombre = "Leonardo"},
            //    new{Nombre = "Juan"}
            //};
            
            //Circulo[] circulos = { new Circulo(20), new Circulo(5),  };
           

            //var tipo = numeros.GetType();
            //try
            //{
            //    var numero3 = circulos[0];
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
                
            //}

            //int [] numeros = {145,2,3,4};
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //foreach (var circulo in circulos)
            //{
            //    Console.WriteLine(circulo.radio);
            //}

            //var datos = inicializar();

            int[] arreglo = {3, 4, 87, 456, 685};
            int[] arreglo2 = (int[])arreglo.Clone();

            Array.Copy(arreglo,arreglo2,arreglo.Length);
            

            //for (int i = 0; i < arreglo.Length; i++)
            //{
            //    arreglo2[i] = arreglo[i];
            //}

            Console.WriteLine(arreglo[0]);
            Console.WriteLine(arreglo2[0]);

            arreglo[0] = 50;

            Console.WriteLine(arreglo[0]);
            Console.WriteLine(arreglo2[0]);

            int[,] bidimensional = new int[5,5];
            bidimensional[0, 0] = 1;
            bidimensional[3, 3] = 10;
        }

        static void GenerarReporte(int[] datos)
        {

        }

        static int[] inicializar()
        {
            Console.WriteLine("Numero de elementos");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("el valor para el elemento ");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                numeros[i] = dato;
            }

            return numeros;
        }
    }
}
