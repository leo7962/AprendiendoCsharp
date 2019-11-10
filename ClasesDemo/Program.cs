using static System.Console;
using static ClasesDemo.Circulo;

namespace ClasesDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Definición de un objeto nuevo 
            //var rectangulo = new Rectangulo(23, 50);

            //var resultadoArea = rectangulo.CalcularArea();
            //var resultadoPerimetro = rectangulo.calcularPerimetro();

            //var resultadoPerimetro2 = Rectangulo.CalcularPerimetroRectangulo(23, 24);

            //var (baseRect, alturaRect) = rectangulo;

            //Console.WriteLine(baseRect);
            //Console.WriteLine(alturaRect);

            //Console.WriteLine(Math.Pow(2, 2));

            var circulo1 = new Circulo(20);
            var circulo2 = new Circulo(50);
            var circulo3 = new Circulo(10);

            //Circulo.PI = 5;

            WriteLine(numeroDeCirculos);

            var objetoAnonimo = new {area = 3, campo2 = 5, campo3 = 10};
        }
    }
}