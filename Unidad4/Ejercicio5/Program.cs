using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        /*
        5. Hacer un programa para ingresar 4 números. 
        Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
        */
        {
            int a, b, c, d;
            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            d = int. Parse(Console.ReadLine());
            if(a > b && b > c && c > d )
                Console.WriteLine("Los numeros estan ordenados en forma decreciente");
            else
                Console.WriteLine("No se encuentra ordenados en forma decreciente");
        }
    }
}
