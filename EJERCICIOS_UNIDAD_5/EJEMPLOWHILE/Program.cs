using System;

namespace EJEMPLOWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont=0;
            
            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());

            while(n != 0){
                cont++;
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresaste " + cont + " nros");
        }
    }
}
