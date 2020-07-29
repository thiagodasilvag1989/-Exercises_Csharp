using System;

namespace Exe_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### TABUADA DE MULTIPLICAÇÃO ##########");
            Console.Write("Digite o Numero: ");
            
            int N = int.Parse(Console.ReadLine());

            //Estrutura de Repitição
            for (int x = 0; x <= 10; x++)
            {
                //Variavel que guarda a multiplicação
                int resut = x * N;
                Console.WriteLine($"{x} x {N} = {resut}");
            }
        }
    }
}
