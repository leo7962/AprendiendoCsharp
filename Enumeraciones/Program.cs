using System;

namespace Enumeraciones
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tipoUsuario = Rol.Administrador;
            string temporal = tipoUsuario.ToString();

            switch (tipoUsuario)
            {
                case Rol.Administrador:
                    Console.WriteLine(tipoUsuario);
                    break;
                case Rol.Desarrollador:
                    Console.WriteLine(tipoUsuario);
                    break;
                case Rol.Usuariofinal:
                    Console.WriteLine(tipoUsuario);
                    break;
            }

            Console.ReadLine();
        }

        public static void ValidarUsuario(Rol rol)
        {
        }
    }
}