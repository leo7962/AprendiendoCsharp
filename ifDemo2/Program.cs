using System;

namespace ifDemo2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////expresión if (variable booleana)
            ////enunciado -1
            ////else
            ////enunciado -2
            //if (53 == 5)
            //{
            //    Console.WriteLine("sí");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //bool mayorEdad = true;
            //int costoEntrada = 0;

            //if (mayorEdad == true)
            //{
            //    Console.WriteLine("es mayor de edad");
            //    costoEntrada = 20;
            //}
            //else
            //{
            //    Console.WriteLine("es menor de edad");
            //    costoEntrada = 10;
            //}

            var dia = 7;

            if (dia == 0)
                Console.WriteLine("Es Lunes");
            else if (dia == 1)
                Console.WriteLine("Es martes");
            else if (dia == 2)
                Console.WriteLine("Es miercoles");
            else if (dia == 3)
                Console.WriteLine("Es jueves");
            else if (dia == 4)
                Console.WriteLine("Es viernes");
            else if (dia == 5)
                Console.WriteLine("Es sábado");
            else if (dia == 6)
                Console.WriteLine("Es Domingo");
            else
                Console.WriteLine("digita un número entre 0 y 6");


            Console.ReadLine();
        }
    }
}