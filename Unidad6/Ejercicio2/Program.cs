using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            Se pide determinar e informar:

            El número de grupo con mayor porcentaje de números impares respecto al total de números 
            que forman el grupo.
            Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            */
            int n, min, contadorOrdenados=0;
            bool ordenados;
            int  maxGrupo=0, maxP=0;
            int conNumeros=0, conImpares=0, porcentaje;
            for(int x = 0; x < 3; x++ ){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                conImpares=0;
                conNumeros=0;
               min = n;
               ordenados= true;
                while(n!=0)
                {
                   if(n % 2!=0){
                       conImpares++;
                    }
                    if(n <= min){
                        min= n;
                    }
                    else{
                        ordenados= false;
                    }

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                conNumeros++;
                }
                porcentaje=(conImpares/ conNumeros)*100;
                if(x==0){
                    maxP=porcentaje;
                    maxGrupo = (x+1);
                }
                else if(porcentaje> maxP){
                    maxP= porcentaje;
                    maxGrupo = (x+1);
                }
               if(ordenados==true){
                contadorOrdenados++;
                
               }
                
            }
            Console.WriteLine("El grupo con el mayor porcentaje de numeros impares es: " + maxGrupo);
            Console.WriteLine("Hay "+ contadorOrdenados + " grupos de numeros ordenados de mayor a menor ");
        }
    }
}
