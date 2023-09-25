using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO___3bimestre
{
        class Medico : Funcionario
        {
            public string CRM { get; set; }
            public decimal ValorHoraExtra { get; set; }
            public string Especialidade { get; set; }

            public Medico(string nome, string cpf, string matricula, DateTime dataNascimento, char sexo, decimal salario, string crm, decimal valorHoraExtra, string especialidade)
                : base(nome, cpf, matricula, dataNascimento, sexo, salario)
            {
                CRM = crm;
                ValorHoraExtra = valorHoraExtra;
                Especialidade = especialidade;
            }

            public override decimal CalcularSalarioTotal()
            {
                decimal salarioAuxilioPericulosidade = Salario * 1.2m;
                return salarioAuxilioPericulosidade + ValorHoraExtra;
            }
        }
}

