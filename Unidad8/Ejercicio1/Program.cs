using System;

namespace Ejercicio1
{
    class Program
    {
        /*
        1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto 
        de ambos. 
        Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre 
        por pantalla el monto total a pagar. Usar la función.
        */
        static void Main(string[] args)
        {
            int n1, n2, Total;
            Console.WriteLine("Ingrese el precio del producto: ");
            n1= int. Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            n2= int.Parse(Console.ReadLine());
            Total= Producto( n1, n2);
            Console.WriteLine("El monto total a pagar es: "+ Total);
        }
        static int Producto(int a,int b){
            // Es correcto de las dos maneras...
            //int Producto = a*b;
            //return Producto;
            return a*b;
        }
    }
}
