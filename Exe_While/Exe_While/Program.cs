using System;

namespace Exe_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada da senha
            Console.Write("Digite a Senha: ");
            //Variavel que armazena a senha
            int senha = int.Parse(Console.ReadLine());
            
            //Estrutura de Repetição (enquanto "senha" ->diferente de<- "2002" repita)
            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite a Senha: ");
                senha = int.Parse(Console.ReadLine());
                
            }
            //Caso "senha" seja "2002" mostre em tela
            Console.WriteLine("Acesso Permitido");
        }
    }
}
