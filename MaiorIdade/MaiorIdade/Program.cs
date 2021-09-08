using System;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Gabriel";
            pessoa.Idade = 19;
            pessoa.verificaDados();

        }
    }
}
