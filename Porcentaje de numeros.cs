using System;
using Punto_4;
using utilidades2;

namespace Punto_4
{ class    rango{
            public void decimales(){
            utilidades.mostrar("Ingrese dos numeros, primero el mayor y luego el menor");
            double n1=utilidades.S2D(Console.ReadLine());
            double n2=utilidades.S2D(Console.ReadLine());
            utilidades.mostrar("Ingrese la cantidad de numeros que desea ingresar");
            int aux=utilidades.S2I(Console.ReadLine());
            int aux1=0;    
            for (int i = 1; i<=aux; i++){
                utilidades.mostrar("Ingrese el numero "+i);
            double n3=utilidades.S2D(Console.ReadLine());    
            if (n3>n2 && n1>n3){
            aux1=aux1+1;
                }
            }
            double porciento=((aux1*100)/aux);
            utilidades.mostrar("El porcentaje de numeros ingresado dentro del rango es "+porciento+"%");
            utilidades.mostrar("La cantidad de numeros dentro del rango de los dos primeros ingresados es "+aux1);
            
            
            
        }
    
    }

}

    class Program
    {
        public static void Main(string[] args)
        {
            
            rango objas;
            objas=new rango();
            objas.decimales();
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
