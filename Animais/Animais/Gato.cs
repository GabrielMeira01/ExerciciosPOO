using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Gato : Animais
    {
        public void dadosGato(string cor, string porte, string raca)
        {
            this.cor = cor;
            this.porte = porte;
            this.raca = raca;

            dadoAnimais();
        }
    }
}
