using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla 
            cuáles son mayores a 100.
            */
            int a, b, c, d;
            Console.WriteLine("Ingrese el 1° numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2° numero: ");
            b = int.Parse(Console.ReadLine());
            Console. WriteLine("Ingrese el 3° numero: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 4° numero: ");
            d = int.Parse(Console.ReadLine());
            if(a>100){
                Console.WriteLine("El primero numero "+ a + " es mayor a 100");
            }
            if(b>100){
                Console.WriteLine("El segundo numero " + b + " es mayor a 100");
            }
            if(c>100){
                Console.WriteLine("El tercer numero "+ c + " es mayor a 100");
            }
            if(d>100){
                Console.WriteLine("El cuarto numero "+ d + " es mayor a 100");
            }
        }
    }
}
