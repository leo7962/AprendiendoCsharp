using System;

namespace ClasesDemo
{
    internal class Circulo
    {
        private readonly int radio;
        public static int numeroDeCirculos;
        public const double PI = 3.14;

        public Circulo(int radioInicial)
        {
            radio = radioInicial;
            numeroDeCirculos++;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}