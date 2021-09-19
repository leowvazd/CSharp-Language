// Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. 
// Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
// Cada nota deve ser validada separadamente.

using System; 

class minhaClasse {

    public static void Main() {
    double soma = 0;
    int contador = 0;
      
    do {
      double entrada = double.Parse(Console.ReadLine());

      if(entrada < 0 || entrada > 10) {
        Console.WriteLine("nota invalida");
      } else {
        contador++;
        soma += entrada; 
      }
    } while (contador < 2);
    
    Console.WriteLine("media = " + (soma / 2).ToString("N2"));
  }
}