using ProvaPOO___3bimestre;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        while (true)
        {
            Console.WriteLine("Escolha o tipo de funcionario a ser cadastrado: ");
            Console.WriteLine("1- Medico ");
            Console.WriteLine("2- Funcionario Administrativo");
            Console.WriteLine("3- Sair");

            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 3)
            {
                break;
            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Matricula: ");
            string matricula = Console.ReadLine();

            Console.WriteLine("Data de Nascimento: ");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Sexo M/F: ");
            char sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Salario");

            decimal salario = Convert.ToDecimal(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("CRM: ");
                string crm = Console.ReadLine();

                Console.WriteLine("valor da hora extra: ");
                decimal ValorHoraExtra = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Especialidade");
                string especialidade = Console.ReadLine();

                Medico medico = new Medico(nome, cpf, matricula, dataNascimento, sexo, salario, crm, ValorHoraExtra, especialidade);
                funcionarios.Add(medico);
            }
            else if (escolha == 2)
            {
                Console.Write("Funcao: ");
                string funcao = Console.ReadLine();

                FuncionarioAdministrativo funcAdmin = new FuncionarioAdministrativo(nome, cpf, matricula, dataNascimento, sexo, salario, funcao);
                funcionarios.Add(funcAdmin);
            }
            Console.WriteLine("\nLista de funcionario cadastrados: ");

        }            
    } 
}