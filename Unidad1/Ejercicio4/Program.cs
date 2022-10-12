using System;

namespace Ejercicio4
{
    class Program
    {
        /* 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más 
        una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa 
        para ingresar el total facturado por un empleado y que luego calcule y 
        emita por pantalla el sueldo total a cobrar por el mismo.*/
        //sueldo fijo 15000
        //5% sobre el total facturado
        static void Main(string[] args)
        {
            float totalFacturado, sueldoacobrar;
            float sueldoFijo = 15000;
            float comision = 0.05F;
            Console.WriteLine("Ingrese el total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());
            sueldoacobrar= sueldoFijo + (totalFacturado*comision);// totalFacturado*0.05F agregandole la F funciona sin error
            Console.WriteLine("Total a cobrar es $: "+ sueldoacobrar);    
        }
    }
}
