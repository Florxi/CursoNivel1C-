using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos 
           (tres ingresos). 
           El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado 
           hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            CADENA FUENTE: “La mar estaba serena"
            CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            CADENA RESULTADO: “Li mir estibi sereni"
            */
            char[] frase = new char[30];
            char LetraActual;
            char LetraNueva;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una Letra para la frase: ");
            letra= char.Parse(Console.ReadLine());

            while(letra!= '0' && indice < 30){
            frase[indice] = letra;
            Console.WriteLine("Ingrese una Letra para la frase: ");
            letra= char.Parse(Console.ReadLine());
            indice++;
            }
            frase[indice] = '\0';
            Console.WriteLine("La Frase completa es: ");
            indice = 0;
            while(frase[indice] != '\0'){
                Console.Write(frase[indice]);
                indice++;
            }
            Console.WriteLine("Ingrese letra a reemplazar: ");
            LetraActual= char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva ");
            LetraNueva= char.Parse (Console.ReadLine());
            indice=0;
            while(frase[indice]!= '\0'){
                if(frase[indice]==LetraActual)
                    frase[indice]=LetraNueva;
               indice++;     
               
            }
            Console.WriteLine("La Frase nueva es: ");
            indice=0;
            while(frase[indice]!= '\0'){
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
