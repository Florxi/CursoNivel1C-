using System;

namespace TPFinal_DominguezFerreira
{
    class Program
    {
               /*
        Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
        A partir de dichos datos informar:

        a. El mayor de los números pares.
        b. La cantidad de números impares.
        c. El menor de los números primos.

        Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva 
        true o false según corresponda.
        */
        static void Main(string[] args)
        {
            int n, maxiPar=0, conImpar=0; 
           Console.WriteLine("Ingrese un numero: "); 
            n = int.Parse(Console.ReadLine()); 
            int menPrimo=n;
            while(n != 0){
                if(n % 2 == 0){
                    if(maxiPar<n){
                        maxiPar=n;
                    }
                }
                else{
                    conImpar++;
                }
                
                if(primo(n)){
                    if(menPrimo >= n){
                        menPrimo = n;
                    }
                }
            Console.WriteLine("Ingrese otro numero: ");
            n = int.Parse(Console.ReadLine()); 

            }
            Console.WriteLine("El Mayor de los numeros pares es: "+ maxiPar);
            Console.WriteLine("La cantidad de numeros impares son: "+ conImpar);
            Console.WriteLine("El menor de los números primos es: "+ menPrimo);
        }
        
        static bool primo (int numero){
            int con=0;
            for(int x=1; x <= numero; x++){
                if(numero % x == 0){
                    con++;
                }
            }
            if(con==2){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
