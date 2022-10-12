using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            5. Hacer un programa que solicite 20 números y 
            luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            */
            int n, maxPar=0, minImpar=0;
            bool banPar=false, banImpar= false;
            for(int x = 0; x < 20 ; x++){
                Console.WriteLine("Ingrese un numero: ");
                n= int.Parse(Console.ReadLine());
                
                if(n%2==0){
                    if(banPar==false){
                    maxPar = n;

                    banPar = true;
                    }
                    else if(maxPar < n){
                            maxPar = n;
                        }
                    
                }
                else {
                    if(banImpar==false){
                        minImpar = n;
                        banImpar=true;
                    }
                    else if(minImpar > n){
                            maxPar = n;
                        }
                    
                }

            }
            Console.WriteLine("El maximo de los Pares es: "+ maxPar);
            Console.WriteLine("El minimo de los Impares es: "+ minImpar);
        }
    }
}
