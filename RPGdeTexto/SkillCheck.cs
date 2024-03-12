using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class SkillCheck
    {
        public static void skill(List<string> personagensLista)
        {
            Console.WriteLine("Pressine 'M' para exibir o menu de personagens! 'N' Para sair! ");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.M)
                {
                    foreach (var personagem in personagensLista) { Console.WriteLine(personagem); }
                }
                else if(Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    return;
                }
            }
        }
        public static void skillItems(List<string> personagensItems)
        {
            
            Console.WriteLine("Pressine 'L' para exibir o menu de personagens! 'K' Para sair! ");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.L)
                {
                    foreach (var personagem in personagensItems) { Console.WriteLine(personagem); }
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.K)
                {
                    return;
                }
            }
        }
    }
}
