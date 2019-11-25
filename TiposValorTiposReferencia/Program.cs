using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace TiposValorTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int valor1 = 50;
            //int valor2 = valor1;

            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);

            //valor1++;

            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);

            //Circulo circ1 = new Circulo();
            //circ1.radio = 50;

            //Circulo circ2 = circ1;

            //Console.WriteLine((circ1.radio));
            //Console.WriteLine(circ2.radio);

            //circ1.radio = 20;

            //Console.WriteLine((circ1.radio));
            //Console.WriteLine(circ2.radio);

            //int numero1 = 0;
            //AgregarUno(numero1);

            //Circulo circulo = new Circulo();
            //circulo.radio = 10;
            //AgregarUno(circulo);

            //Circulo circulo = null;

            //if (circulo != null)
            //{
            //   Console.WriteLine(circulo.radio);
            //}
            //Console.WriteLine(circulo?.radio);

            //int? i = null;
            ////i = 10;

            //int? j = 0;

            //j = i;

            //if ((!i.HasValue))
            //{
            //    i = 10;
            //}
            //else
            //{
            //    Console.WriteLine(i.Value);
            //}

            //int numero = 10;
            //AgregarUno(ref numero);

            //int numero2;
            //AgregarUno(out numero2);

            //int.TryParse("50", out int pruebaconversion1);
            //Console.WriteLine(pruebaconversion1);

            //object entero = 13;
            //object cadena = "Hola Mundo";
            //Circulo ciculo = new Circulo();
            //ciculo.radio

            int valor = 50;
            Object objeto = 40;

            //int otrovalor =(int) objeto;
            if (objeto is int)
            {
                Console.WriteLine(objeto);   
            }else if (objeto is Circulo)
            {
                Circulo circulo = (Circulo) objeto;
                Console.WriteLine(circulo.radio);
            }

            Circulo valor2 = objeto as Circulo;
            if (valor2 != null)
            {
                Console.WriteLine(valor2);
            }
        }

        public static void AgregarUno(out int param1)
        {
            param1 = 0;
            param1++;
        }

        public static void AgregarUno(Circulo circulo)
        {
            circulo = new Circulo();
            circulo.radio = 50;
            
        }
    }
}
