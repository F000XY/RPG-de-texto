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
                Console.WriteLine("Chegamos ao final do Caminho da Bala com louvor");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Uma escolha não tão sabia! Tome cuidado para não ficar preso no chiclete..");
                Console.WriteLine("Após andar o sol começou a derreter o chiclete e grudar em seus pés..O que fazer?");
                Console.WriteLine("DICA: Poção de veneno é corrosiva! Digite 1- Usar poção, 2- Usar suas armas.");
                int escolhaChiclete;
                if (!int.TryParse(Console.ReadLine(), out escolhaChiclete)) { }
                if (escolhaChiclete == 1) { Console.WriteLine("Você conseguiu!! Chegou ao final do Caminho do Chiclete!"); }
                else if(escolhaChiclete == 2) { Console.WriteLine("Você conseguiu por pouco!! Chegou ao final do Caminho do Chiclete! Agora descanse"); }
            }
            else
            {
                Console.WriteLine("Não entendi! Tente de novo!!");
            }      

        }
        public static void caminhos3() 
        {
            Console.WriteLine("Vamos continuar.. Agora temos a decisão entre Caminho dos Pirulitos e do Marshmallow");
        
        }
    }
}
