using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente
            */
            int a, b, m;
            Console.WriteLine("Ingrese el primer numero ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero ");
            b = int.Parse(Console.ReadLine());
            if(a>b){
                m = a - b;
                Console.WriteLine("El resultado es: "+ m); 
            } 
            else if(a==b){
                m = a + b;
                Console.WriteLine("El Resultado es: "+ m);
            }
            else{
                m = a * b;
                Console.WriteLine("El Resultado es: "+ m);
            }
        }
    }
}
