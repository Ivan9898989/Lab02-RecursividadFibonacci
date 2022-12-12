namespace Lab02_Recursividad;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Seleccionar metodo: \n1. Recursivo \n2. Iterativo");
        string? metodo = Console.ReadLine();
        int.TryParse(metodo, out int m);
        switch(m){
            case 1:
            do{
                Console.WriteLine("Introduzca el numero de terminos: ");
                string? ingreso = Console.ReadLine();
                int.TryParse(ingreso, out n);
            }while(n<=1);
            DateTime inicioRecur = DateTime.Now; 
            Console.WriteLine("Serie numeros de fibonacci recursivo: ");
            for( int k=0; k<n; k++){
                Console.Write(new Program().fibonacciRecursivo(k)+" ");
                }
            double tiempo = DateTime.Now.Subtract(inicioRecur).Milliseconds;    
            Console.WriteLine("\nTiempo: "+tiempo+" ms");
            break;
            case 2:
            do{
                Console.WriteLine("Introduzca el numero de terminos: ");
                string? ingreso = Console.ReadLine();
                int.TryParse(ingreso, out n);
                }while(n<=1);
            DateTime inicioIter = DateTime.Now;

            Console.WriteLine("\nSerie de fibonacci Iterativo");
            new Program().fibonacciIterativo(n);
            double tiempoIter = DateTime.Now.Subtract(inicioIter).Milliseconds;    
            Console.WriteLine("\nTiempo: "+tiempoIter+" ms");
            break;
        }
    }

    long fibonacciRecursivo(int n){
        if (n<2){
            return n;
        } else {
            return fibonacciRecursivo(n-2)+ fibonacciRecursivo(n-1);
        }
    }

    void fibonacciIterativo (int n){
        int ant1,ant2;
        ant1=ant2=1;
        Console.Write("0 1 1 ");
        for(int i = 1; i < n-2; i++){
            int actual = ant1 + ant2;
            Console.Write(actual+" ");
            ant2=ant1;
            ant1=actual;
        }
    }
}
