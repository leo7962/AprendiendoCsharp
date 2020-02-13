using System;

namespace TiposValorTiposReferencia
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            object objeto = 40;

            //int otrovalor =(int) objeto;
            if (objeto is int)
            {
                Console.WriteLine(objeto);
            }
            else if (objeto is Circulo)
            {
                Circulo circulo = (Circulo)objeto;
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
            circulo = new Circulo
            {
                radio = 50
            };

        }
    }
}
