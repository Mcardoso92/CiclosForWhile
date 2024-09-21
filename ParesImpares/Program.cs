using System;

namespace EJERCICIO5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el 
            //máximo de los números pares y el mínimo de los números impare

            int n, maxp = 0, mini = 0;
            int conPar = 0, conImpar = 0;
            bool banPar = false, banImpar = false;

            for(int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if(n%2 == 0){
                    //Trabajo con los pares
                    if(banPar == false){
                        maxp = n;
                        banPar=true;
                    }
                    else if(n > maxp)
                        maxp = n;                        
                }else{
                    //Trabajo con los impares
                    conImpar++;
                    if(conImpar == 1){
                        mini = n;
                    }
                    else if(n < mini){
                        mini=n;
                    }

                }
            }

            Console.WriteLine("El maximo par es: " + maxp);
            Console.WriteLine("El minimo impar es: " + mini);
        }
    }
}
