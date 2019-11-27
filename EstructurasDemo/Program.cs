using System;
using System.Runtime.InteropServices;

namespace EstructurasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           //StructPoint s1 = new StructPoint();
           //StructPoint s2 = s1;

           //Console.WriteLine(s1.X);
           //Console.WriteLine(s2.X);

           //s1.X++;

           //Console.WriteLine(s1.X);
           //Console.WriteLine(s2.X);

           ClassPoint s1 = new ClassPoint();
           ClassPoint s2 = s1;

           Console.WriteLine(s1.X);
           Console.WriteLine(s2.X);

           s1.X++;

           Console.WriteLine(s1.X);
           Console.WriteLine(s2.X);

            Console.ReadLine();
        }
       
    }
}
