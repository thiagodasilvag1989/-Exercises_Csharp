using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_78Listas
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return "ID: " + Id + "| Nome: " + Name + "| Salary: " + Salary;
        }
    }
}
