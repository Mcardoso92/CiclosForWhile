using System;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos 
            //por pantalla. Solo se debe emitir UN valor por pantalla.

            int n, acum = 0;

            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                
                
                if(i == 0)
                    acum = n;
                else{
                    if(n > acum)
                        acum = n;
                }
            }

            Console.WriteLine("El mayor de los nros es: " + acum);
        }
    }
}
