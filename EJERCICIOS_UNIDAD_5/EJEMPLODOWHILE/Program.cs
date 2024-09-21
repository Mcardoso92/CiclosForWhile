using System;

namespace EJEMPLODOWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            do{
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                cont++;
            }while(n != 0);

            Console.WriteLine("Ingresaste " + cont+ " nros");
        }
    }
}
