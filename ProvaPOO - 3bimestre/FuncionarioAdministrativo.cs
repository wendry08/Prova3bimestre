using ProvaPOO___3bimestre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO___3bimestre
{
  
        class FuncionarioAdministrativo : Funcionario
        {
            public string Funcao { get; set; }

            public FuncionarioAdministrativo(string nome, string cpf, string matricula, DateTime dataNascimento, char sexo, decimal salario, string funcao)
                : base(nome, cpf, matricula, dataNascimento, sexo, salario)
            {
                Funcao = funcao;
            }
            public decimal CalcularSalario()
            {
                decimal SalarioComValeTransporte = Salario + 150m;
                decimal SalarioComValeAlimentacao = SalarioComValeTransporte * 1.15m;
                return SalarioComValeAlimentacao;
            }

        }
}

