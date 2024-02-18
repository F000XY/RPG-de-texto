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
        public static void apresentarLojinha()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=BEM VINDO A LOJINHA=-=-=-=");

            Console.WriteLine("Aqui voce encontrará itens de melhoras" +
                "de atributos para seu personagem");
        }
    }

    class Pocoes
    {
        public static void apresentarPocoes()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=P O Ç Õ E S=-=-=-=-=-=");
            Console.WriteLine("Poções são itens que podem ser " +
                "usados para recuperar pontos de vida ou fornecer outros efeitos benéficos.");
        }
    }

    class PocaoCura
    {
        public static void ApresentarPocaoCura()
        {
            int vida = 50;
            Console.WriteLine("=-=Poção de Cura=-=", "Uma poção que restaura ou aumenta" +
                " temporariamente uma parte da sua saúde em: " + vida);
        }
    }

    class PocaoForca
    {
        public static void ApresentarPocaoForca()
        {
            int forca = 100;
            Console.WriteLine("=-=Poção de Força=-=", "Uma poção que aumenta" +
                " temporariamente sua força em: " + forca);
        }
    }

    class PocaoVeneno
    {
        public static void ApresentarPocaoVeneno()
        {
            int vida = -50;
            Console.WriteLine("=-=Poção de Veneno=-=", "Cuidado! Esta poção causa " +
                "dano ao invés de cura em: " + vida);
        }
    }

    class Armas
    {
        public static void apresentarArmas()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=-A R M A S-=-=-=-=-=-=");
            Console.WriteLine("Armas são itens que podem ser " +
                "usados para dar mais dano de ataque em monstros.");
        }
    }

    class Machado
    {
        public static void ApresentarMachado()
        {
            int dano = 60;
            Console.WriteLine("=-=Machado Obsidiana Negra=-=", " Item para ladinos! Preto como a noite, e resistente" +
                " como diamante, o Machado de Obisidiana Negra, aprimora o dano do ladino em: " + dano);
        }
    }

    class Arco
    {
        public static void ApresentarArco()
        {
            int dano = 70;
            Console.WriteLine("=-=Arco Lapis Lazuli=-=", " Item para arqueiros! Azul como o céu e" +
                "  veloz como uma águia, o Arco Lapis Lazuli, aprimora o dano do arqueiro em: " +
                " vezes mais: " + dano);
        }
    }

    class Espada
    {
        public static void ApresentarEspada()
        {
            int dano = 80;
            Console.WriteLine("=-=Espada de Prisma=-=", " Item para guerreiros! transparenre como água corrente" +
                "  e mais afiado diamante, a Espada de Prisma, aprimora o dano do guerreiro em: " +
                " vezes mais: " + dano);
        }
    }

    class Armaduras
    {
        public static void apresentarArmas()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-A R M A D U R A S-=-=-=-=");
            Console.WriteLine("Armaduras são itens para guerreiros, podem ser " +
                "usados para dar mais resistencia e pontos de vida.");
        }

    }
    class TunicaArcana
    {
        public static void ApresentarTunicaArcana()
        {
            int dano = -20;
            Console.WriteLine("=-=Túnica Arcana=-=", " Item para defeza de mágia! " +
                "Reduz o dano de ataques mágicos em: " + dano);
        }
    }
    class PlacasdeBatalha
    {
        public static void ApresentarPlacasdeBatalha()
        {
            int dano = -25;
            Console.WriteLine("=-=Placas de Batalha=-=", " Item para defeza de física! " +
                "Reduz o dano de ataques físicos em: " + dano);
        }
    }
    class Acessorios
    {
        public static void apresentarAcessorios()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=A C E S S O R I O S=-=-=-=");
            Console.WriteLine("Acessorios são itens para usuários de magia, podem ser " +
                "usados para dar mais dano de ataque em monstros.");
        }
    }
    class CajadodaCuraEterna 
    {
        public static void ApresentarCajadodaCuraEterna()
        {
            int vida = 55;
            Console.WriteLine("=-=Cajado da Cura Eterna=-=", " Item para Clérigos! " +
                "aumenta e restaura a vida em: " + vida);
        }
    }
    class OrbedaNaturezaAncestral
    {
        public static void ApresentarOrbedaNaturezaAncestral()
        {
            int forca = 35;
            Console.WriteLine("=-=Orbe da Natureza Ancestral=-=", " Item para Druidas! " +
                "aumenta a forca de todos os aliados em: " + forca);
        }
    }
    class LivrodosArcanosAntigos
    {
        public static void ApresentarLivrodosArcanosAntigos()
        {
            int forca = 35;
            Console.WriteLine("=-=Livro dos Arcanos Antigos=-=", " Item para Magos! " +
                "aumenta a forca em: " + forca+ " ,possui todo tipo de feitiço.");
        }
    }
}