using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    class Pessoa
    {
        public int idade;
        public string nome;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //metodos
        private string verificaIdade(int idade)
        {

            return idade >= 18 ? "Você é maior de idade" : "Você é menor de idade";

        }

        public void verificaDados()
        {
            string checaIdade = verificaIdade(Idade);

            Console.WriteLine("Olá " + this.Nome);
            Console.WriteLine("Você tem " + this.Idade + " anos");
            Console.WriteLine(checaIdade);
        }
    }
}
