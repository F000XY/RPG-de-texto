using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class RandomizacaoDeDados
    {

        public static void GerarNumeroAleatorio()
        {
            Random random = new Random();
            // Gerando um número aleatório entre 1 e 20
            int numeroAleatorio = random.Next(1, 21);
            Console.WriteLine(numeroAleatorio);
        }

    }
    class Ataque : RandomizacaoDeDados{ }
    class Resistencia : RandomizacaoDeDados { }
    class Iniciativa : RandomizacaoDeDados { }
}
