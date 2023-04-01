{
    class Numeros{
        public int numeros(){
            int n=Convert.ToInt32(Console.ReadLine());
            int auxpar=0;
            int auximpar=0;
            int auxpositivo=0;
            int auxneg=0;
            int sumaposi=0;
            for (int i = 1; i <= n; i++){
                utilidades.mostrar("Ingrese un numero");
                int x=Convert.ToInt32(Console.ReadLine());
                if (utilidades.par(x)==true){
                auxpar++;
                
                }
                else{
                  auximpar++;    
                }
                if (utilidades.positivo(x)==true){
                  auxpositivo++;
                  sumaposi=sumaposi+x;
                }
                else{
                 auxneg++;    
                }
            }
            utilidades.mostrar("Cantidad de numeros pares"+auxpar);
            utilidades.mostrar("Cantidad de numeros impares"+auximpar);
            utilidades.mostrar("Cantidad de numeros positivos"+auxpositivo);
            utilidades.mostrar("Cantidad de numeros negativos"+auxneg);
            utilidades.mostrar("Suma de todos los positivos"+sumaposi);
            return 0;
            
        }
    }
}

    class Program
    {
        public static void Main(string[] args)
        {
            Numeros objnum;
            objnum= new Numeros();
            utilidades.mostrar("Ingrese la cantidad de numeros a ingresar");
              double resultado=objnum.numeros();
            Console.WriteLine(resultado );
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
