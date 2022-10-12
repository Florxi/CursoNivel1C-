using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2. Hacer un programa que solicite el ingreso de 10 números y 
            que muestre el mayor de ellos por pantalla. 
            Solo se debe emitir UN valor por pantalla.
            */
            
            
            
            //tiene una falencia solo funciona con numeros positivos
            /*int max = 0, n;
            for(int x = 0; x < 10; x++){
                Console.WriteLine("Ingrese un numero: ");
                n= int.Parse(Console.ReadLine());
                if(n > max){
                    max = n;
                }
            }
            Console.WriteLine("El valor del mayor es: "+ max);*/
            

            //CORRECTA
            int n, max =0;
            for(int x = 0; x < 10; x++ ){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                if(x==0){
                    max = n;
                }
                else{ 
                    if(n > max) {
                    max= n;
                }
                }
            } 
            Console.WriteLine("El maximo de los numeros ingresados es: "+ max);

        }
    }
}
