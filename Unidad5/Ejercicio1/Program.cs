using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Hacer un programa para mostrar los números del 1 al 10. 
            No se debe realizar ningún pedido de datos.
            */

            //PRIMER FORMA:
            /*for(int x = 0; x < 10; x++ ){
                Console.WriteLine(x+1);
            }*/


           //SEGUNDA FORMA:
            int con = 1;
            while(con <= 10){
                Console.WriteLine(con);
                con++;
            }

        }
    }
}
