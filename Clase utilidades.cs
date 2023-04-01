{
    class utilidades{
    public double suma(double n1, double n2){
        double aux=n1+n2;
        return aux;
    }
    public double resta(double n3, double n4){
        double aux=n3-n4;
        return aux;
    }
        public double mult(double n5, double n6){
        double aux=n5*n6;
        return aux;
    }
    public double div(double n7, double n8){
        if (n8==0){
            Console.WriteLine("El segundo valor debe ser distinto de 0");
            return 0;
        }
        double aux=n7/n8;
        return aux;
    }
    public double calctri(double n9, double n10){

        double aux=(n9*n10)/2;
            return aux;
    }
    public double calcrec(double n11, double n12){
        double aux=(n11)*(n12);
        return aux;
    }
    
    public double calccir(double n13){
        double aux=n13*3.14;
            return aux;
    }
    public double calcpertri(double n15, double n16, double n17){
        double aux=n15+n16+n17;
            return aux;
    }
        public double calcperrec(double n18, double n19){
        double aux=(n18*2)+(n19*2);
            return aux;
    }
    public double calcpercirc(double n20){
        double aux=3.14*n20;
        return aux;
    }
    
        public static void mostrar (string texto1){
            Console.WriteLine(texto1);
        }
        
        public double calcmayor (double n21, double n22){
            if (n21 > n22){    
        
            double aux1=n21;
            return aux1;

        }
            else {
                double aux1=n22;
                return aux1;
            }
        }
            public void menoramayor(int n23, int n24){
                for (int i=n23; i<=n24; i++){
                    Console.WriteLine(i);
                    }
           
        } 
        
        public bool positivo(int n25){
            bool positiv = (n25 > 0);
            Console.WriteLine(positiv);
            return positiv;    
        }
        public bool par(int n26){
            bool par=(n26%2==0);
            Console.WriteLine(par);
            return par;
        }
        
        public int cantnec(int capmax, int canttotal){
            int aux2=1;
            while (capmax>canttotal){
                aux2=aux2+1;
                capmax=(capmax-canttotal);
                    
            }
            return aux2;
        }
        
          public int S2I(string var1) {
            try{
                return Convert.ToInt32(var1);
                
            }
            catch{
                return 0;
            }
        }
        public string I2S(int var2){
            return Convert.ToString(var2);
        }
        
        public double S2D(string var3){
            try{
                return Convert.ToDouble(var3);
            }
            catch{
                return 0;
            }
        }
        public string D2S(double var4){
            return Convert.ToString(var4);

        }
    }
}
        
    

    class Program
    {
        public static void Main(string[] args)
        {
            
            utilidades objuti;
            objuti = new utilidades();
            

     
            
             
            Console.WriteLine("Ingrese valor 1 a sumar");
            double n1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese valor 2 a sumar");
             double n2=Convert.ToDouble(Console.ReadLine());
            double resultado=objuti.suma(n1,n2);
            Console.WriteLine("El resultado de la suma es:" +resultado );
            
            
                 Console.WriteLine("Ingrese valor 1 a restar");
            double n3=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2 a restar");
            double n4=Convert.ToDouble(Console.ReadLine());
            double resultado1=objuti.resta(n3,n4);
            Console.WriteLine("El resultado de la resta es:" +resultado1 );
            
                Console.WriteLine("Ingrese valor 1 a multiplicar");
            double n5=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2 a multiplicar");
            double n6=Convert.ToDouble(Console.ReadLine());
            double resultado2=objuti.mult(n5,n6);
            Console.WriteLine("El resultado de la multiplicacion es:" +resultado2 );
            
                Console.WriteLine("Ingrese valor 1 a dividir");
            double n7=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2 a dividir");
            double n8=Convert.ToDouble(Console.ReadLine());
            double resultado3=objuti.div(n7,n8);
            Console.WriteLine("El resultado de la division es:" +resultado3 );
            
                Console.WriteLine("Ingrese la base y altura del triangulo");
                Console.WriteLine("Ingrese base del triangulo");
            double n9=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese altura 2 del triangulo");
            double n10=Convert.ToDouble(Console.ReadLine());
            double resultado4=objuti.calctri(n9,n10);
            Console.WriteLine("La superficie del triangulo es:" +resultado4 );
            
                Console.WriteLine("Ingrese la base y altura del rectangulo");
                Console.WriteLine("Ingrese base del rectangulo");
            double n11=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese altura 2 del rectangulo");
            double n12=Convert.ToDouble(Console.ReadLine());
            double resultado5=objuti.calcrec(n11,n12);
            Console.WriteLine("La superficie del rectagulo es:" +resultado5 );
            
  
                 Console.WriteLine("Ingrese el radio del circulo");
            double n13=Convert.ToDouble(Console.ReadLine());
            double resultado6=objuti.calccir(n13);
            Console.WriteLine("La superficie del circulo es:" +resultado6 );
            
                Console.WriteLine("Ingrese la longitud de cada lado del triangulo");
                Console.WriteLine("Ingrese valor 1 para calcular el perimetro del triangulo");
            double n15=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2 para calcular el perimetro del triangulo");
            double n16=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 3 para calcular el perimetro del triangulo");
            double n17=Convert.ToDouble(Console.ReadLine());
            double resultado7=objuti.calcpertri(n15,n16,n17);
            Console.WriteLine("El perimetro del triangulo:" +resultado7 );
            
            
                Console.WriteLine("Ingrese la longitud de cada lado del rectangulo");
                Console.WriteLine("Ingrese valor 1 para calcular el perimetro del rectangulo");
            double n18=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2 para calcular el perimetro del rectangulo");
            double n19=Convert.ToDouble(Console.ReadLine());
            double resultado8=objuti.calcperrec(n19,n18);
            Console.WriteLine("El perimetro del rectangulo:" +resultado8 );
            
                 Console.WriteLine("Ingrese el diametro para calcular el perimetro del circulo");
            double n20=Convert.ToDouble(Console.ReadLine());
            double resultado9=objuti.calcpercirc(n20);  
             utilidades.mostrar("El perimetro del circulo:" +resultado9 );
             
                 Console.WriteLine("Ingrese valor 1 a comparar");
            double n21=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2 a comparar");
            double n22=Convert.ToDouble(Console.ReadLine());
            double resultado10=objuti.calcmayor(n21,n22);
             utilidades.mostrar("El numero mayor es:" +resultado10);
             
            utilidades.mostrar("Ingrese el numero menor");
            int n23=Convert.ToInt32(Console.ReadLine());
            utilidades.mostrar("Ingrese el numero mayor");
            int n24=Convert.ToInt32(Console.ReadLine());
               objuti.menoramayor(n23,n24);
            
            utilidades.mostrar("Ingrese numero a saber si es positivo");
            int n25=Convert.ToInt32(Console.ReadLine());
            objuti.positivo(n25);
            
            utilidades.mostrar("Ingrese numero a saber si es par");
            int n26=Convert.ToInt32(Console.ReadLine());
            objuti.par(n26);
            
            utilidades.mostrar("Ingrese la cantitad total");
            int capmax = Convert.ToInt32(Console.ReadLine());
            utilidades.mostrar("Ingrese la capacidad maxima");
            int canttotal = Convert.ToInt32(Console.ReadLine());
            utilidades.mostrar("La cantidad necesaria es");
            Console.WriteLine(objuti.cantnec(capmax,canttotal));
        
            
          string var1=(Console.ReadLine());
          objuti.S2I(var1);
          
          int var2=objuti.S2I(Console.ReadLine());
          objuti.I2S(var2);
          
          string var3=(Console.ReadLine());
          objuti.S2D(var3);

          double var4=objuti.S2D(Console.ReadLine());
          objuti.D2S(var4);
          
      
             
             
             
             
              
             
            
            
           
            
             
             
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    
    }