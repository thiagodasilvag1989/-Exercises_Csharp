using System;
using System.Collections.Generic;
using Exe_133HeP.Entities;

namespace Exe_133HeP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Product: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> List = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, Used or Imported ( c | u | i )");
                char tp = char.Parse(Console.ReadLine());

                Console.WriteLine($"Product #{i} data:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (tp == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    List.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (tp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    List.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    List.Add(new Product(name, price));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Price Tags");
            foreach (Product obj in List)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
