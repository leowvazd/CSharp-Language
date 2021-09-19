// Leia um valor inteiro X (1 <= X <= 1000). 
// Em seguida mostre os ímpares de 1 até X, 
// um valor por linha, inclusive o X, se for o caso.

using System; 

class minhaClasse {

        public static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int i = 0; i <= n; ++i) //complete seu codigo
            {
                if (i % 2 != 0)
                {
                  Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();
        }

}
