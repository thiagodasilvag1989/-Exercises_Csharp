using Exe60_ContaBancaria.Entiteis;
using System;


namespace Exe60_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia d Classe AccountBank
            AccountBank account = new AccountBank();
            //Entarda de dados
            Console.Write("Entre o Numero da Conta: ");
            account.AddNumConta(int.Parse(Console.ReadLine()));
            Console.Write("Entre o Titular da Conta: ");
            account.AddTitular(Console.ReadLine());
            Console.Write("Haverá deposito inicial? (s/n): ");
            account.DepositoInicial(char.Parse(Console.ReadLine()));
            
            Console.WriteLine();
            Console.WriteLine(account.ToString());

            Console.Write("Entre um valor de deposito: ");
            account.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(account.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            account.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(account.ToString());
        }
    }
}
