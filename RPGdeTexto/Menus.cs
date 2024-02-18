using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGdeTexto
{
    internal class Menus
    {
       public static void escolhaMenu()
       {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-BEM VINDO AO RPG DE TEXTO-=-=");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Escolha um personagem com sabedoria jovem guerreiro!");
            Console.WriteLine("1. Guerreiro");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Arqueiro");
            Console.WriteLine("4. Clerigo");
            Console.WriteLine("5. Ladino");
            Console.WriteLine("6. Druida");
            Console.WriteLine("7. Adicionar outro personagem ");
            Console.Write("Digite o número desejado: "); 
       }
        
        public static void escolhaLojinha()
        {
            Console.WriteLine("Escolha um personagem com sabedoria jovem guerreiro!");
            Console.WriteLine("1. Poção Cura");
            Console.WriteLine("2. Poção Força");
            Console.WriteLine("3. Poção Veneno");

            Console.WriteLine("4. Machado Obsidiana Negra");
            Console.WriteLine("5. Arco Lapis Lazuli");
            Console.WriteLine("6. Espada de Prisma");

            Console.WriteLine("7. Túnica Arcana");
            Console.WriteLine("8. Placas de Batalha");

            Console.WriteLine("9. Cajado da Cura Eterna");
            Console.WriteLine("10. Orbe da Natureza Ancestral");
            Console.WriteLine("11. Livro dos Arcanos Antigos");
            Console.Write("Digite o número desejado: ");
        }
    }
}
