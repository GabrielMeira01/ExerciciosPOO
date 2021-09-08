using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Animais : IAnimais
    {
        protected string cor, porte, raca;

        public string Cor
        {
            get { return cor; }
            set { value = cor; }
        }

        public string Porte
        {
            get { return porte; }
            set { value = porte; }
        }

        public string Raca
        {
            get { return raca; }
            set { value = raca; }
        }


        protected void dadoAnimais()
        {
            Console.WriteLine("Cor: " + this.Cor);
            Console.WriteLine("Porte: " + this.Porte);
            Console.WriteLine("Raça: " + this.Raca);
        }
    }
}
