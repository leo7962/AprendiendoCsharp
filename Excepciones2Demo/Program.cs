using System;

namespace Excepciones2Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int entero = int.MaxValue;

            ////checked
            ////{
            ////     entero++;
            ////}

            //entero = unchecked(entero++);

            //Console.WriteLine();

            int mes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(obtenerSignoZodiacal(mes));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Bloque Finally");
            }


            Console.ReadLine();
        }

        private static string obtenerSignoZodiacal(int numeroMes)
        {
            string resultado = string.Empty;
            switch (numeroMes)
            {
                case 1:
                    resultado = "Aries";
                    break;
                case 2:
                    resultado = "Tauro";
                    break;
                case 3:
                    resultado = "Géminis";
                    break;
                case 4:
                    resultado = "Cáncer";
                    break;
                case 5:
                    resultado = "Leo";
                    break;
                case 6:
                    resultado = "Aries";
                    break;
                case 7:
                    resultado = "Virgo";
                    break;
                case 8:
                    resultado = "Escorpio";
                    break;
                case 9:
                    resultado = "Sagitario";
                    break;
                case 10:
                    resultado = "Capricornio";
                    break;
                case 11:
                    resultado = "Acuario";
                    break;
                case 12:
                    resultado = "Picis";
                    break;
                default:
                    throw new Exception("Mes invalido");
                    break;
            }

            return resultado;
        }
    }
}