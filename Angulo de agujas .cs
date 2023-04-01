using System;
using Punto_4;
using utilidades2;

namespace Punto_4
{ class    grados{
        public void agujas(){
            utilidades.mostrar("Ingresar hora e ingresar minutos");
            int hora=utilidades.S2I(Console.ReadLine());
            int minutos=utilidades.S2I(Console.ReadLine());
            int auxhora2=30*hora;
            double auxminuto2=0.5*minutos;
            double auxhorafinal=auxhora2+auxminuto2;
            
            int auxminutofinal=6*minutos;
            double angulo=(auxhorafinal-auxminutofinal);
            Console.WriteLine("A las "+hora+" horas con "+minutos + " minutos la aguja de la hora se movio " +auxhorafinal+"º");
            Console.WriteLine("La aguja de los minutos se movio "+auxminutofinal+"º");
            Console.WriteLine("Y el angulo entre las dos agujas es "+angulo+"º");
            
            }        
        }
    
    }


    class Program
    {
        public static void Main(string[] args)
        {
            
            grados objas;
            objas=new grados();
            objas.agujas();
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }