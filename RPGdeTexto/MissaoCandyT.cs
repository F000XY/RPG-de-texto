using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class MissaoCandyT
    {
        public static void caminhos()
        {
            Console.WriteLine("Aqui em Candy Town, cidade bela e açucarada, nossos herois se deparam com caminhos que mais parecem" +
                "labirintos, o nosso objetvo é chegar no castelo será que venceremos essa trilha?");
            Console.WriteLine("Cada encruzilhada possuirá alguns caminhos e cabe a vocês jovens sabios escolher a trilha.. com sorte chegaram ao" +
                "castelo");
        }
        public static void caminhos2()
        {
            Console.WriteLine("Vamos começar.. temos duas trilhas a seguir, 1 - Caminho da Bala 2- Caminho do Chiclete.. decida-se");
            int escolha;
            if (!int.TryParse(Console.ReadLine(), out escolha)) { }
            if (escolha == 1)
            { 
                Console.WriteLine("Uma boa escolha o Caminho da Bala é mais eficiente que do Chiclete, durante a luz do dia o Chiclete torna-se" +
                    "pegajoso e ruim para andar");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Uma escolha não tão sabia! Tome cuidado para não ficar preso no chiclete..");
                int escolhaChiclete;
                if (!int.TryParse(Console.ReadLine(), out escolhaChiclete)) { }
                Console.WriteLine("Após andar");
            }

               

        }
    }
}
