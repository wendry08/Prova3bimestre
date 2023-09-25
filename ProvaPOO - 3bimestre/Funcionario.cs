using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPOO___3bimestre
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, string cpf, string matricula, DateTime dataNascimento, char sexo, decimal salario)
        {
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Salario = salario;
        }

        public virtual decimal CalcularSalarioTotal()
        {
            return Salario;
        }
    }
}
