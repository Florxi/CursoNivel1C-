using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Hacer un programa para ingresar un número y 
            luego se emita por pantalla un cartel aclaratorio si 
            “Es mayor a 10” o “No es mayor a 10”.
            */
            int n;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if(n > 10)
                Console.WriteLine("Es Mayor a 10 ");
            else
                Console.WriteLine("No es Mayor a 10");
        }
    }
}
