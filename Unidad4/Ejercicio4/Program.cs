using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la 
            suma de los dos primeros es mayor al producto del segundo con el tercero.
            */
            int a,b,c,suma,multiplicacion;
            Console.WriteLine("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            c = int.Parse(Console.ReadLine());
            suma = a + b;
            multiplicacion = b * c;
            if(suma>multiplicacion)
                Console.WriteLine("La Suma de los primeros numeros es mayor al producto del segundo con el tercero");
            Console.WriteLine("Fin del Programa");
        }
    }
}
