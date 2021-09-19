using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Criação da conta
                Endereco endereco = new Endereco("Rua AAA", "123", "São Paulo", "SP");
                Cliente cliente = new Cliente("Leo", "000000", "123456", endereco);
                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + 
                    conta.DigitoVerificador);
                
                // Abertura de conta
                string senha = "senha";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                // Utilização da conta
                conta.Sacar(10, senha);
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(50);
                Console.WriteLine(conta.VerSaldo());

                conta.Sacar(20, senha);
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(10);
                Console.WriteLine(conta.VerExtrato());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
