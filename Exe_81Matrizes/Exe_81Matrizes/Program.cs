using System;

namespace Exe_81Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o tamanho da Matriz: ");
            string[] line = Console.ReadLine().Split(' ');
            int l = int.Parse(line[0]);
            int c = int.Parse(line[1]);

            int[,] mat = new int[l, c];

            for(int i = 0; i < l; i++)
            {
                Console.WriteLine("Digite os valores das linha #:" + i);
                string[] values = Console.ReadLine().Split (' ');
                for(int x = 0; x < c; x++)
                {
                    mat[i, x] = int.Parse(values[x]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Digite um valor da matriz");
            int count = int.Parse(Console.ReadLine());
            for (int g = 0; g < l; g++)
            {
                for (int w = 0; w < c; w++)
                {
                    if (mat[g, w] == count)
                    {
                        Console.WriteLine("Posição " + g + "," + w + ":");
                        if (w > 0)
                        {
                            Console.WriteLine("Lado Esquerdo: " + mat[g, w - 1]);
                        }
                        if (g > 0)
                        {
                            Console.WriteLine("Em cima: " + mat[g - 1, w]);
                        }
                        if (w < c - 1)
                        {
                            Console.WriteLine("Lado Direito: " + mat[g, w + 1]);
                        }
                        if (g < l - 1)
                        {
                            Console.WriteLine("Em baixo: " + mat[g + 1, w]);
                        }
                    }
                }
            }

        }
    }
}
