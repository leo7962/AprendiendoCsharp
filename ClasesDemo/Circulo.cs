using System;

namespace ClasesDemo
{
    internal class Circulo
    {
        public const double PI = 3.14;
        public static int numeroDeCirculos;
        private readonly int radio;

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