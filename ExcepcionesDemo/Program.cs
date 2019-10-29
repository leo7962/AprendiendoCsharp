using System;

namespace ExcepcionesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este es el manejo de excepciones 

           

            //Console.WriteLine(numeroconvertido);

            //try
            //{
            //operaciones que queramos llevar
            //}
            //catch (tipo de excepción ex)
            //{
            //dado casi que ocurra una excepción
            //}

            try
            {
                int valor = 10;
                Console.WriteLine(valor / 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir entre cero" + ex);
            }

            try
            {
                //Convertir un string número a una cadena 
                string numeroencadena = "1a";
                int valor = int.Parse(numeroencadena);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Unicamente se aceptan números" + ""+ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Solamente se aceptan números "+""+ex);
            }

            try
            {
                //string numerogrande = "99999999999";
                //int numeroconvertido = int.Parse(numerogrande);
                 string numeroencadena = "1a";
                int valor = int.Parse(numeroencadena);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


            Console.ReadLine();
        }
    }
}
