using System;
using System.Collections.Generic;

namespace Exe_78Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instacia da Lista
            List<Employee> List = new List<Employee>();

            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine("Employees #: "+x);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                //Dados passado para lista por paramentro da classe Employee
                List.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employees id that will have salary increase: ");
            int buscaId = int.Parse(Console.ReadLine());
            //Expressão Lambda para busca do Id
            Employee emp = List.Find(x => x.Id == buscaId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreseSalary(percentage);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            //Busca dos Employees na lista
            foreach(Employee obj in List)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
