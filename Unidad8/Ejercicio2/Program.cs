using System;

namespace Ejercicio2
{
    class Program
    {
        /*
        2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero 
        si no lo es. 
        Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        */
        static void Main(string[] args)
        {
            int a, r;
            int acum=0;
            for(int x=0; x<20 ; x++){

            Console.WriteLine("Ingrese un numero");
            a = int.Parse (Console.ReadLine());
            r = par(a);
            acum += r;
            // me ahorro la variable r y aca se ve que puedo llamar a una funcion en un if
            //if(par(a))
            //     acum++;
            }
            
            Console.WriteLine("Los numeros pares son: "+ acum);
        }
        //static bool par(int a)
        static int par (int a){
            if(a % 2 == 0){
                return 1;
                //return true;
            }
            else{
                return 0;
                //return false;
            }
        }
    }
}
