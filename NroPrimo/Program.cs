﻿using System;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio 
            //si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente 
            //por 1 y por sí mismo.

            int n, cont = 0;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){   
                if(n % i == 0){
                    cont++;
                }
            }

            if(cont == 2)
                Console.WriteLine("El nro ingresado es primo");
            else
                Console.WriteLine("El nro ingresado no es primo");
            
        }
    }
}
