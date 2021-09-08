using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Peixe peixe = new Peixe();
            Gato gato = new Gato();
            Cachorro cachorro = new Cachorro();


            peixe.dadosPeixe("dourado", "pequeno", "peixe1");
            Console.WriteLine("___________________________________________________________________");
            gato.dadosGato("preto", "medio", "gato1");
            Console.WriteLine("___________________________________________________________________");
            cachorro.dadosCachorro("branco", "grande", "cachorro1");
        }
    }
}
