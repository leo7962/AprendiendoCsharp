namespace ClasesDemo
{
    //Class nombre de clase
    //{
    //}
    internal class Rectangulo
    {
        private readonly double altura;
        private readonly double baseRectangulo;
        private readonly string color;

        public Rectangulo()
        {
            baseRectangulo = 15;
            altura = 3;
            color = "black";
        }

        public Rectangulo(double baseRectanguloInicial, double alturaRectanguloInicial)
        {
            baseRectangulo = baseRectanguloInicial;
            altura = alturaRectanguloInicial;
        }

        public double CalcularArea()
        {
            // A = H * B            
            return altura * baseRectangulo;
        }

        public double calcularPerimetro()
        {
            // P = 2 * H + 2 * b
            return 2 * altura + 2 * baseRectangulo;
        }

        public static double CalcularPerimetroRectangulo(double alturaRectangulo, double baseRectangulo)
        {
            return 2 * alturaRectangulo + 2 * baseRectangulo;
        }

        public void Deconstruct(out double baseRect, out double alturaRect)
        {
            baseRect = baseRectangulo;
            alturaRect = altura;
        }
    }
}