using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class Lojinha
    {
        public static void ApresentarLojinha()
        {
            Console.WriteLine("=-=-=-=BEM VINDO A LOJINHA=-=-=-=");

            Console.WriteLine("Aqui voce encontrará itens melhores itens para seu personagem");
        }

        //PASSIVEL DE MUDANÇA CRIEI VARIOS METODOS PARA EVITAR QUE BAGUNCE AS VARIAVEIS
        class Pocoes
        {
            public static void ApresentarPocoes()
            {
                Console.WriteLine("=-=-=-=-=-=P O Ç Õ E S=-=-=-=-=-=");
                Console.WriteLine("Poções são itens que podem ser usados para recuperar pontos de vida ou fornecer outros efeitos benéficos.");
            }
            public static void ApresentarPocaoCura()
            {
                int vida = 50;
                Console.WriteLine("=-=Poção de Cura=-= Uma poção que restaura ou aumenta temporariamente uma parte da sua saúde em: " + vida);
            }
            public static void ApresentarPocaoForca()
            {
                int forca = 100;
                Console.WriteLine("=-=Poção de Força=-= Uma poção que aumenta temporariamente sua força em: " + forca);
            }
            public static void ApresentarPocaoVeneno()
            {
                int vida = -50;
                Console.WriteLine("=-=Poção de Veneno=-= Cuidado! Esta poção causa dano ao invés de cura em: " + vida);
            }
        }


        class Armas
        {
            public static void apresentarArmas()
            {
                Console.WriteLine("=-=-=-=-=-=-A R M A S-=-=-=-=-=-=");
                Console.WriteLine("Armas são itens que podem ser usados para dar mais dano de ataque em monstros.");
            }
            public static void ApresentarMachado()
            {
                int forca = 60;
                Console.WriteLine("=-=Machado Obsidiana Negra=-= Item para ladinos! Força: +" + forca);
            }
            public static void ApresentarArco()
            {
                int forca = 70;
                Console.WriteLine("=-=Arco Lapis Lazuli=-= Item para arqueiros! Força: +" + forca);
            }
            public static void ApresentarEspada()
            {
                int forca = 80;
                Console.WriteLine("=-=Espada de Prisma=-= Item para guerreiros! Força: +" + forca);
            }
        }


        class Armaduras
        {
            public static void apresentarArmas()
            {
                Console.WriteLine("=-=-=-=-A R M A D U R A S-=-=-=-=");
                Console.WriteLine("Armaduras são itens para guerreiros, podem ser usados para dar mais resistencia e pontos de vida.");
            }
            public static void ApresentarTunicaArcana()
            {
                int forca = 20;
                Console.WriteLine("=-=Túnica Arcana=-= Item para defeza de mágia! Aumeta a força: " + forca);
            }
            public static void ApresentarPlacasdeBatalha()
            {
                int forca = 20;
                Console.WriteLine("=-=Placas de Batalha=-= Item para defeza de física!Aumeta a força: " + forca);
            }

        }

        class Acessorios
        {
            public static void apresentarAcessorios()
            {
                Console.WriteLine("=-=-=-=A C E S S O R I O S=-=-=-=");
                Console.WriteLine("Acessorios são itens para usuários de magia, podem ser usados para dar mais dano de ataque em monstros.");
            }
            public static void ApresentarCajadodaCuraEterna()
            {
                int vida = 55;
                Console.WriteLine("=-=Cajado da Cura Eterna=-= Item para Clérigos! Aumenta sua vida e restaura a vida de todos em batalha: +" + vida);
            }
            public static void ApresentarOrbedaNaturezaAncestral()
            {
                int forca = 35;
                Console.WriteLine("=-=Orbe da Natureza Ancestral=-= Item para Druidas! Aumenta sua força e em batalha todos os aliados em: +" + forca);
            }
            public static void ApresentarLivrodosArcanosAntigos()
            {
                int forca = 35;
                Console.WriteLine("=-=Livro dos Arcanos Antigos=-= Item para Magos! Aumenta a forca em: +" + forca);
            }
        }
        public static void ApresentarTudo()
        {
           // ApresentarLojinha();
            Console.WriteLine(" "); 

            // Apresentar as poções
            Pocoes.ApresentarPocoes();
            Thread.Sleep(2000);
            Pocoes.ApresentarPocaoCura();
            Pocoes.ApresentarPocaoForca();
            Pocoes.ApresentarPocaoVeneno();
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            // Apresentar as armas
            Armas.apresentarArmas();
            Thread.Sleep(2000);
            Armas.ApresentarMachado();
            Armas.ApresentarArco();
            Armas.ApresentarEspada();
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            // Apresentar as armaduras
            Armaduras.apresentarArmas();
            Thread.Sleep(2000);
            Armaduras.ApresentarTunicaArcana();
            Armaduras.ApresentarPlacasdeBatalha();
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            // Apresentar os acessórios
            Acessorios.apresentarAcessorios();
            Thread.Sleep(2000);
            Acessorios.ApresentarCajadodaCuraEterna();
            Acessorios.ApresentarOrbedaNaturezaAncestral();
            Acessorios.ApresentarLivrodosArcanosAntigos();
            Console.WriteLine(" ");
        }
    }

    
}