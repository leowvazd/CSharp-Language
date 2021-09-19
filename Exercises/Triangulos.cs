// Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. 
// A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

// se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
// se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
// se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
// se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
// se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
// se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

using System; 

class Desafio {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
  
            double x = 0.0;
            if (a < b){ x = a; a = b; b = x; } 
            if (b < c){ x = b; b = c; c = x; } 
            if (a < b){ x = a; a = b; b = x; }
            
            //continue a solucao
            if (a >= (b+c))
                Console.WriteLine("NAO FORMA TRIANGULO");
                
            else if (a * a == b * b + c * c)
                Console.WriteLine("TRIANGULO RETANGULO");
                
            else if (a*a > (b*b) + (c*c))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                
            else if (a * a < b * b + c * c)
                Console.WriteLine("TRIANGULO ACUTANGULO");
                
            if (a == b && a == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
                
            if ((a == b && a != c) || (a == c && a != b) || b == c && b != a)
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
}