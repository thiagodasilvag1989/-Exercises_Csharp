using System;
using System.Collections.Generic;
using System.Text;

namespace Exe60_ContaBancaria.Entiteis
{
    class AccountBank
    {
        //Atributos da Conta
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; }

        //Construtor
        public AccountBank(int numeroConta, string nomeTitular, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }
        public AccountBank()
        {

        }

        public void DepositoInicial (char cond)
        {
            if (cond == 's' || cond == 'S')
            {
                Console.Write("Entre com Valor de Deposito Inicial: ");
                Saldo = (double.Parse(Console.ReadLine()));

            }
        }

        public void AddNumConta(int numeroConta)
        {
            NumeroConta = numeroConta;
        }

        public void AddTitular (string nomeTitular)
        {
            NomeTitular = nomeTitular;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double saldo)
        {
            Saldo -= saldo+5;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular da Conta: " + NomeTitular + ", Saldo R$: " + Saldo;
        }
    }
}
