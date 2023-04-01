using System;
using Punto_4;
using utilidades2;

namespace Punto_4
{ class    Fechas{
            public void formato(){
            
            utilidades.mostrar("Ingrese dia, mes y año");
            int dia=utilidades.S2I(Console.ReadLine());
            int mes=utilidades.S2I(Console.ReadLine());
            int año=utilidades.S2I(Console.ReadLine());
            if(dia>29 && mes==2){
                utilidades.mostrar("Febrero solo puede llegar a tener 29 dias");
            }
            if(dia>31 && mes!=2 && mes<=12){
                utilidades.mostrar("Solo puede haber 31 dias en la mayoria de los meses");
            }
            else{
            switch (mes) {            
                    case 1: utilidades.mostrar("El día " + dia + " de enero del año " + año);
                        break;
                    case 2: utilidades.mostrar("El día " + dia + " de febrero del año " + año);
                        break;
                    case 3: utilidades.mostrar("El día " + dia + " de marzo del año " + año);
                        break;
                    case 4: utilidades.mostrar("El día " + dia + " de abril del año " + año);
                        break;
                    case 5:utilidades.mostrar("El día " + dia + " de mayo del año " + año);
                        break;
                    case 6:utilidades.mostrar("El día " + dia + " de junio del año " + año);
                        break;
                    case 7: utilidades.mostrar("El día " + dia + " de julio del año " + año);
                        break;
                    case 8: utilidades.mostrar("El día " + dia + " de agosto del año " + año);    
                        break;
                    case 9:utilidades.mostrar("El día " + dia + " de septiembre del año " + año);    
                        break;
                    case 10:utilidades.mostrar("El día " + dia + " de octubre del año " + año);
                        break;
                    case 11:utilidades.mostrar("El día " + dia + " de noviembre del año " + año);
                        break;
                    case 12:utilidades.mostrar("El día " + dia + " de diciembre del año " + año);    
                        break;
                        default:utilidades.mostrar("Solo hay 12 meses en el año");
                        break;
                        }
            }
        }
        
        public bool fechaposible(){
            utilidades.mostrar("Ingrese dia, mes y año");
            int dia=utilidades.S2I(Console.ReadLine());
            int mes=utilidades.S2I(Console.ReadLine());
            int año=utilidades.S2I(Console.ReadLine());
            
            bool posible=(dia>31||dia<0||mes<0||mes<12);
            Console.WriteLine(posible);
                return posible;
        }    
        public bool bisiesto(){
            utilidades.mostrar("Ingrese año");
            int año=utilidades.S2I(Console.ReadLine());
            bool posible=(año%4==0||año%4==0 && año%100!=0);
            Console.WriteLine(posible);
                return posible;
        }    
    
    }

}

    class Program
    {
        public static void Main(string[] args)
        {
            
            Fechas objas;
            objas=new Fechas();
            objas.formato();
            
            objas.fechaposible();
            objas.bisiesto();
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
