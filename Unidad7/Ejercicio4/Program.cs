using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un 
            registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de 
            artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10.
            */

            int numeroArt, cantidadVendida,max=0;
            int[] acumulador= new int [15];
            //Incializacion en 0 de los acumuladores 
            for(int x=0; x<15; x++){
                acumulador[x]= 0;
            }
            Console.WriteLine("Ingrese numero de Articulo: ");
            numeroArt= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida= int.Parse(Console.ReadLine());
            while(numeroArt != 0){

                // Acumulo lo que vendio en cada articulo
                acumulador[numeroArt-1] += cantidadVendida;
                Console.WriteLine("Ingrese numero de Articulo: ");
                numeroArt= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidadVendida= int.Parse(Console.ReadLine());
            }
            for(int x=0; x<15;x++){
                if(acumulador[x]==0){
                    Console.WriteLine("Los numeros de Articulos que no obtuvieron ventas son: "+ (x+1));
                }
            }
            max= acumulador[0];
            int art=1;
            for(int x=0; x<15 ; x++){
                if(acumulador[x]>max){
                    max=acumulador[x];
                    art=x+1;
                }
            }
            Console.WriteLine("El Articulo mas vendido es: "+ art);
            Console.WriteLine("En el numero de articulo 10 se vendieron "+ acumulador[9] + " unidades");
        }
    }
}
