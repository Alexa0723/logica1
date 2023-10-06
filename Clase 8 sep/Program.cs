using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Holii");
            Console.Write("Ingresa su nombre:");
            String nombre = Console.ReadLine();
            Console.Write("Ingresa su telefono:");
            String telefono = Console.ReadLine();
            Console.Write("Ingresa su correo:");
            String correo = Console.ReadLine();
            Console.Write("Ingresa su genero:");
            String genero = Console.ReadLine();
            Console.Write("Ingrese su cumpleaños:");
            String cumple = Console.ReadLine();
            Console.Write("Ingresa su edad:");
            int edad = int.Parse(Console.ReadLine());

            Contacto contacto1 = new Contacto(nombre, telefono, correo, genero, cumple,edad);
            Console.WriteLine(contacto1.mostrarDatos());

        }
    }
}
