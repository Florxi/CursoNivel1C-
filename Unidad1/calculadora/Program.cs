using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paso 0 Tipo de dato: int, float,char,bool
            int n1, n2, resultado;
            //Paso 1 Pedir valores
            Console.WriteLine("Ingrese un numero: ");
            //Accion que el programa pida el numero 
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            n2 = int.Parse(Console.ReadLine());
            //Paso 2 realizar calculo
            resultado = n1 + n2;
            //Paso 3 Emitir resultado
            Console.WriteLine ("El Resultado es " + resultado);
            
        }
    }
}
