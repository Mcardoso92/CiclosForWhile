using System;

namespace EJEMPLOFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            CICLO FOR
            for(int i = 0; i < 5; i++){
               Console.WriteLine("Hola Mundo!  " + (i+1));
            }

            int n = 0, prom, suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la nota: ");
                n = int.Parse(Console.ReadLine());
                suma += n;
            }
            prom = suma / 5;
            Console.WriteLine("El promedio de nota es: " + prom);

        

        }
    }
}
