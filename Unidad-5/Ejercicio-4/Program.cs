﻿using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            int n, contador = 0;
            Console.WriteLine("ingrese numero");
            n = int.Parse(Console.ReadLine());
            for(int x = 1; x <= n; x++){
                if(n % x == 0){
                    contador++;
                }
            } 
            if(contador == 2){
                Console.WriteLine("El numero es primo");
            }else{
                Console.WriteLine("El numero no es primo");
            }
        }
    }
}
