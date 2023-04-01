{
    class Conversion_Metricas{
        public double millakm(double milla, double km){
            km=milla*km;
            return 0;
        }
        public double pulgacm(double pulgada, double cm){
        cm=pulgada*cm;
        return 0;        
        }
        
        public double piesacm(double pies, double cm1){
        cm1=pies*cm1;
        return 0;
        }
    }
    
    
    class Program
    {
        public static void Main(string[] args)
        {
            
            Conversion_Metricas objcv;
            objcv = new Conversion_Metricas();
            utilidades.mostrar("Ingrese la cantidad de millas a convertir");
            double milla=utilidades.S2D(Console.ReadLine());
            double km=1.61;
            double resultado=milla*km;
            utilidades.mostrar("La cantidad de km es");
            Console.WriteLine(resultado);
            
            utilidades.mostrar("Ingrese la cantidad de pulgadas a convertir");
            double pulgada=utilidades.S2D(Console.ReadLine());
            double cm=2.54;
            double resultado1=pulgada*cm;
            utilidades.mostrar("La cantidad de cm es");
            Console.WriteLine(resultado1);
            
            utilidades.mostrar("Ingrese la cantidad de pies a convertir");
            double pies=utilidades.S2D(Console.ReadLine());
            double cm1=30.48;
            double resultado2=pies*cm1;
            utilidades.mostrar("La cantidad de cm es");
            Console.WriteLine(resultado2);
            
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}