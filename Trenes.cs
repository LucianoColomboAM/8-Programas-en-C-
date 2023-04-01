 {
            class maquinista{
            public void datos(){
            utilidades.mostrar("Ingrese datos del maquinista en este orden: Nombre, Apellido, DNI");
            string name=(Console.ReadLine());
            string apellido=(Console.ReadLine());
            int dni=utilidades.S2I(Console.ReadLine());
            utilidades.mostrar("Ingrese cantidad de km recorridos en el mes");
            int km=utilidades.S2I(Console.ReadLine());
            utilidades.mostrar("Ingrese precio del km");
            int pkm=utilidades.S2I(Console.ReadLine());
            int salario=pkm*km;
            Console.WriteLine("El salario de " +name +" " +apellido+ " DNI " +dni+ " es "+salario);
                }
            }        
    
        class tren{
        public void comconsu(){
            utilidades.mostrar("Ingrese los siguientes datos del viaje en este orden: Velocidad en milla/h a la que iba el tren y cantidad de millas recorridas");
            int vel=utilidades.S2I(Console.ReadLine());
            int millas=utilidades.S2I(Console.ReadLine());
            double cc=0;
            if (vel < 50){
                cc=(millas/0.4);
                }
            else {
                cc=(millas/0.4)+((millas/0.4)*0.15);
                }
            utilidades.mostrar("Cantidad de combustible consumido");
            Console.WriteLine(cc);
            }
            public  void vagones(){
            utilidades.mostrar("Ingrese la cantidad de vagones del tren");
            int vmyc=0;
            int numvmyc=0;
            int vmnc=999999999;
            int numvmn=0;
            int capcarga;
            int n=utilidades.S2I(Console.ReadLine());
            for (int i = 1; i <= n; i++){
            utilidades.mostrar("Ingrese la capacidad de carga del vagon del vagon "+i);
            capcarga=utilidades.S2I(Console.ReadLine());
            if ( capcarga > vmyc){
            vmyc=capcarga;
            numvmyc=i;            
                    }
            
            if (capcarga < vmnc){
            vmnc=capcarga;
            numvmn=i;            
                    }
                }
            utilidades.mostrar("el vagon con mas capacidad de carga es el "+vmyc);
            utilidades.mostrar("el vagon con menor capacidad de carga es"+numvmn);
            }
            
        }
        class recorrido{
        public  void demora(){
        utilidades.mostrar("Ingrese los siguientes datos del viaje en este orden: Velocidad en km/h a la que iba el tren y cantidad de km recorridos");
            double vel=utilidades.S2D(Console.ReadLine());
            double km=utilidades.S2D(Console.ReadLine());    
            utilidades.mostrar("Ingrese la cantidad de vagones");
            double n1=utilidades.S2D(Console.ReadLine());
            double tiempo;
            double velocidad=vel-(0.25*n1);
            Console.WriteLine("la distancia recorrida es de "+km +" kilometros, a una velocidad de "+velocidad +"km/h");
                
             tiempo=(km/vel)+((km/vel)*(0.025*n1));
     
             double auxtiempo =(tiempo)*60;
            double minuto=60;
            double hora = 0;
               if (auxtiempo<minuto)
            {
                minuto = auxtiempo;
                
            }
            while (auxtiempo>minuto)
            {
                auxtiempo = Convert.ToInt32((auxtiempo-minuto));
                hora++;
            }
            Console.WriteLine("la cantidad de tiempo que ha tardado el tren es de "+hora +"horas y "  +auxtiempo +" minutos");
            }    
        }    
}


    class Program
    {
        public static void Main(string[] args)
        { 
            maquinista objma;
            objma = new maquinista();
            objma.datos();
            
            tren objtre;
            objtre= new tren();
            objtre.comconsu();
            objtre.vagones();
            
            recorrido objre;
            objre=new recorrido();
            objre.demora();
            
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }