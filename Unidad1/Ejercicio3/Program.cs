using System;

namespace Ejercicio3
{
    class Program
    {
        /*Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
        la velocidad promedio de un vehículo. Calcular y emitir por pantalla el 
        tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.*/
        static void Main(string[] args)
        {
            float km, vel, Resultado;
            Console.WriteLine("Ingrese los kilometros: ");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Velocidad: ");
            vel= float.Parse ( Console.ReadLine());
            Resultado= km/vel;
            // KM= KM
            //vel= KM/HS
            //Resultado= HS
            Console.WriteLine ("El tiempo aproximado que demandara llegar es: "+ Resultado.ToString ("0.00") +" horas. ");
        }
    }
}
