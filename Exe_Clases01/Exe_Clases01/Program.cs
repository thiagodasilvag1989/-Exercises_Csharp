using System;
using Exe_Clases01.Entities;

namespace Exe_Clases01
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            //Variaveis do tipo pessoa
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
           
            //Execução do programa
            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();            
            
            //Condição da idade mais velha
            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pesssoa mais velha: " + p1.Name + " : " + p1.Idade);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Name + " : " + p2.Idade);
            }
        }
    }
}
