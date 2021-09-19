// Você terá o desafio de ler um valor inteiro, 
// que é o tempo de duração em segundos de um determinado evento em uma loja, 
// e informe-o expresso no formato horas:minutos:segundos.

using System;

    class MinhaClasse {
        static void Main(string[] args) 
        {
          var tempo = int.Parse(Console.ReadLine());

          var horas = (tempo / 3600); 
          var minutos = (tempo % 3600) / 60; 
          var segundos =  (tempo % 3600) % 60;

          Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }

