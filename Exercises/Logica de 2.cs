// Você terá desafio de escrever um programa que leia dois valores X e Y. 
// A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            //complete o código com sua solução

            for (int i = 1; i <= b; i++){
              Console.Write($"{i} ");
              if (i % a == 0){
                Console.Write("\n");
              }
            }
        }
    }

