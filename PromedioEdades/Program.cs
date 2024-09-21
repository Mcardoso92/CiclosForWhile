using System;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio 
            //de edad de aquellas personas mayores a 18 años.

            int edad = 0, acum = 0, cont = 0;
            float prom;

            for(int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    acum += edad;
                    cont++;
                }
            }

            prom = acum / cont;

            Console.WriteLine("El promedio de las edades es: " + prom);

        }
    }
}
