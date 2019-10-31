namespace ClasesDemo
{
    //Class nombre de clase
    //{
    //}
    class Rectangulo
    {
        double altura;
        double baseRectangulo;
        string color;

        public double CalcularArea()
        {
            // A = H * B            
            return altura * baseRectangulo;
        }

        public double calcularPerimetro()
        {
            // P = 2 * H + 2 * b
            return (2* altura) + (2*baseRectangulo);
        }
    }
}
