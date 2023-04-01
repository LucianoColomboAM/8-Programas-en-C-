using System;
using Punto_8;
using utilidades2;
namespace Punto_8
{ class dibujarfiguras{
        public void menu(){
            utilidades.mostrar("Ingrese 1 si quiere un triangulo, 2 si quiere un rectangulo, 3 si quiere un rombo");
            int n1=utilidades.S2I(Console.ReadLine());
            string aux="";
            string aux1="";
            if(n1==1){
            utilidades.mostrar("Ingrese el tamaño de 2 a 10 de la figura");
            int n2=utilidades.S2I(Console.ReadLine());
            for(int i=1;i<=n2;i++){
             aux=aux.PadLeft(i,'*');
             utilidades.mostrar(aux);
                }    
            }
            if (n1==2){                
            utilidades.mostrar("Ingrese el tamaño de 2 a 10 de la figura");
            int n3=utilidades.S2I(Console.ReadLine());
            if(n3%2==0){
    
                    if(n3==8){
                    n3=3;    
                    }
                    if(n3==6){
                    n3=2;
                        }
                    if (n3==4){        
                    n3=1;
                    }
                    if(n3==10){
                    n3=4;        
                    }                
                    
                    for(int i=1;i<=n3;i++){
                    aux=aux.PadLeft(10,'-');    
                    utilidades.mostrar(aux);
                    }
                    for (int i=1;i<=2;i++){
                    aux1=aux1.PadLeft(4,'-');
                    utilidades.mostrar(aux1+"oo"+aux1);
                    }
                    for(int i=1;i<=n3;i++){
                    aux=aux.PadLeft(10,'-');    
                    utilidades.mostrar(aux);
                    }    
                }
            if(n3%2!=0){
                
                    if(n3==9){
                    n3=4;    
                    }
                
                    if(n3==5){        
                    n3=2;
                    }
                    if(n3==3){
                    n3=1;        
                        }
                    if(n3==7){
                    n3=3;
                        }
                    for(int i=1;i<=n3;i++){
                    aux=aux.PadLeft(10,'-');    
                    utilidades.mostrar(aux);
                    }
                    for (int i=1;i<=1;i++){
                    aux1=aux1.PadLeft(4,'-');
                    utilidades.mostrar(aux1+"oo"+aux1);
                    }
                    for(int i=1;i<=n3;i++){
                    aux=aux.PadLeft(10,'-');    
                    utilidades.mostrar(aux);
                    }    
            }

            }
            if(n1==3){
            utilidades.mostrar("Ingrese el tamaño de 2 a 10 de la figura(debe ser par si o si)");
            int n4=utilidades.S2I(Console.ReadLine());
                        n4=(n4/2)-1;
                        for (int i=0;i<=n4;i++){
                        aux=aux + " ";
                        }
                  
                        for (int i1=0;i1<=n4;i1++){
                            utilidades.mostrar(aux+"//"+aux1+aux1+"\\\\");
                            aux1=aux1+" ";
                             aux=aux.Remove(0,1);
                        }
                       
                        
                        for (int i3=0;i3<=n4;i3++){
                            aux=aux+" ";
                            aux1=aux1.Remove(0,1);
                            utilidades.mostrar(aux+"\\\\"+aux1+aux1+"//");
                        }         
            }
        }
    }
}

    class Program
    {
        public static void Main(string[] args)
        {
            dibujarfiguras objem;
            objem= new dibujarfiguras();
            objem.menu();
            
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
