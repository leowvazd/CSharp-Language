// Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar a mensagem “ eh o maior”. 
// Use a seguinte forma como base:

// MAIORAB = (a+b+abs(a-b))/2

// Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). 
// Um segundo passo, portanto é necessário para chegar no resultado esperado.

using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            
            int ab = a-b;
            
            if (ab < 0)
            {
              ab = ab*-1;
            }
            
            int MAIORAB = (a+b+ab)/2;
            
            int maior2 = MAIORAB - c;
            
            if (maior2 < 0)
            {
              maior2 = maior2*-1;
            }

            int MAIOR = (MAIORAB+c+maior2) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
                        
        }
    }