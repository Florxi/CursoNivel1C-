using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4. Hacer un programa para ingresar cuatro números distintos
            y luego mostrar por pantalla el menor de ellos.
            */
            int n1, n2, n3, n4,minimo;
            

            Console.WriteLine("Ingresar numero 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar numero 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar numero 3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar numero 4: ");
            n4 = int.Parse(Console.ReadLine());
            if(n2 > n1 ){
                minimo = n1;

            }
            else{
                minimo = n2;
            }
            if(minimo > n3 ){
                minimo = n3;
                
            }
            if(minimo > n4 ){
                minimo = n4;
                
            }
           
            Console.WriteLine("El menor numero es " + minimo);
        }
    }
}
