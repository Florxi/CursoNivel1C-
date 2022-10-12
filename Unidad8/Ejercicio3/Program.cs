using System;

namespace Ejercicio3
{
    class Program
    {
        /*
        3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 
        si el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
        El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta
        sólo los números primos.
        */
        static void Main(string[] args)
        {
            int n;
            float promedio, acum=0, con=0;
            Console.WriteLine("Ingresa un numero");
            n= int. Parse(Console.ReadLine());
            while(n!=0){
                if(primo(n)){
                    acum+=n;
                    con++;
                }
            Console.WriteLine("Ingresa un numero");
            n= int. Parse(Console.ReadLine());
            }
            promedio= acum/con;
            Console.WriteLine("El promedio de los numeros primos son: "+promedio);

        }
        static bool primo (int n1){
            int con=0;
            for(int x=1; x<=n1 ;x++){
                if(n1%x==0){
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
