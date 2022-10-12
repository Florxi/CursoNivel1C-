using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3. Hacer un programa que solicite 20 edades y 
            luego calcule el promedio de edad de aquellas 
            personas mayores a 18 años.
            */
            int edad;             
            float acumulador = 0, contador = 0, promedio;

            for(int x = 0; x < 5; x++){
                Console.WriteLine("Ingresa la edad: ");
                edad = int.Parse(Console.ReadLine());
                if(edad>=18){
                    acumulador += edad;
                    contador++;  
                } 
            }
            
            promedio = acumulador/contador;
            Console.WriteLine("El promedio de las personas mayores de 18 años es: " + promedio);
            
        }
    }
}
