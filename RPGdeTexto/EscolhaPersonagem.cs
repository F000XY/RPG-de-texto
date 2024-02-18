using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class EscolhaPersonagem
    {
       public static void escolhaMenu()
       {
            Console.WriteLine("Escolha um personagem:");
            Console.WriteLine("1. Guerreiro");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Arqueiro");
            Console.WriteLine("4. Clerigo");
            Console.WriteLine("5. Ladino");
            Console.WriteLine("6. Druida");
            Console.WriteLine("7. Você deseja adicionar outro personagem? ");
            Console.Write("Digite o número do personagem desejado: ");
       }
    }
}
