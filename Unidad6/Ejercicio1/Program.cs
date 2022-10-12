using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Hacer un programa para ingresar 10 números. 
            El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            */
            int n;
            int con=0;
            int contadorPrimos = 0;
            for(int x = 0; x < 5; x++){
              Console.WriteLine("Ingrese un numero: ");  
              n = int.Parse(Console.ReadLine());
              con = 0;
              for(float y = 1; y <= n; y++){
                    if(n % y == 0){
                        con++;
                    }
              }
               if(con == 2){
                contadorPrimos++;
              }

            }
           
            Console.WriteLine("De los 10 numeros ingresados hay " + contadorPrimos + " numeros primos");
                
              }
            }
            
        }

