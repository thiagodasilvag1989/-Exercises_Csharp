using System;
using System.IO;

namespace Array
{
    class Program
    {
        static int[] ar = { 1, 2, 3, 4, 10, 11 };

        static int simpleArraySum(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                int resut = +ar[i];
                return resut;

            }

            static void Main(string[] args)
            {

                int result = simpleArraySum(ar);

                Console.WriteLine(result);


            }
        }
    }
}
