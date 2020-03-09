using System;

namespace interfacesAbstractasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f = new Figura();
            Circulo c = new Circulo();
            Linea l = new Linea();

            f.Dibujar();
            c.Dibujar();
            l.Dibujar();
        }
    }
}
