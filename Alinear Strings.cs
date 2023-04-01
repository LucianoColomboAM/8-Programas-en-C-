using System;
using Punto_4;
using utilidades2;

namespace Punto_4
{ class alinear_string{
            public void CentroString(){
            utilidades.mostrar(Ingrese una palabra y el numero de espacios);
            string MyString=(Console.ReadLine());
            int cantidad_caracteres=utilidades.S2I(Console.ReadLine());
            string aux=;
            int aux1=0;
            aux1 = ((cantidad_caracteres - (MyString.Length))  2);
              aux=aux.PadLeft(aux1,'-');
            utilidades.mostrar(aux+MyString+aux);
            
        }
        public void DerechaString(){
        utilidades.mostrar(Ingrese una palabra y el numero de espacios);
            string MyString=(Console.ReadLine());    
            int cantidad_caracteres=utilidades.S2I(Console.ReadLine());
            string aux=;
            int aux1=0;
            if ((MyString.Length)cantidad_caracteres){
                
                aux1=(( MyString.Length)-cantidad_caracteres);
                MyString=(MyString.Remove(0, aux1));
                
                utilidades.mostrar(MyString);
            }
            else{
                 aux1 =(cantidad_caracteres - (MyString.Length));
                  aux=aux.PadLeft(aux1,'-');
                  utilidades.mostrar(aux+MyString);
            }
            
        }
    }
    
}

    class Program
    {
        public static void Main(string[] args)
        {
            
            alinear_string objas;
            objas=new alinear_string();
            objas.CentroString();
            objas.DerechaString();
            
             TODO Implement Functionality Here
            
            Console.Write(Press any key to continue . . . );
            Console.ReadKey(true);
        }
    }