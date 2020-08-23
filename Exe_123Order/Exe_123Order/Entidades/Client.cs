using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Exe_122.Entidades;

namespace Exe_122.Entidades
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public Client()
        {

        }

        public override string ToString()
        {
            return $"{Name}, ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}
