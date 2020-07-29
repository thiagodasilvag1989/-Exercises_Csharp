using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exe_Class_02.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        //Método que subitrai imposto do salario
        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        //Método de aumentar salario em porcetagem
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        //Método |override "diz que o metodo vem de outra class" | String "Tipo de saida" | ToString "Tipo de Função"
        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
