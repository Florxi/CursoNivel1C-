﻿using System;

namespace Ejercicio4
{
    class Program
    {
        /*
        4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
        que reciba un número por valor y una variable por referencia. 
        Que analice el número y escriba variable recibida por referencia con:

        a. 1 si el número es positivo.
        b. -1 si el número es negativo.
        c. 0 si el número es cero.
        */
        static void Main(string[] args)
        {
            int n,j=9;
            Console.WriteLine("Ingrese un numero: ");
            n= int.Parse(Console.ReadLine());
            positivoNegativoCero(n , ref j);
            Console.WriteLine ("El numero es: "+ j);
        }

        static void positivoNegativoCero(int a, ref int  b){
            if(a>0){
                b = 1;
            }
            else if(a==0){
                b=0;
            }
            else {
                b=-1;
            }
        }
    }
}
