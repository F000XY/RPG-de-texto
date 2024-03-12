using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace RPGdeTexto
{
    internal class MissaoGigante
    {
        //aqui pretendo fazer um combo com skills checks
        public static void testeDoGigante()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Pressione dentro de 5 segundos:");
            Console.WriteLine("Pressine as teclas corretas para ganhar a batalha, tudo dependerá dos acertos e erros");
            while (stopwatch.ElapsedMilliseconds < 9000)
            {
                Console.WriteLine("PRESSIONE --> M");
                if (Console.ReadKey(true).Key == ConsoleKey.M)
                {
                    Console.WriteLine("Boa!");
                }
                else
                {
                    Console.WriteLine("Você errou!");
                    return;
                }
                Console.WriteLine("PRESSIONE --> G");
                if (Console.ReadKey(true).Key == ConsoleKey.G)
                {
                    Console.WriteLine("Boa!");
                }
                else
                {
                    Console.WriteLine("Você errou!");
                    return;
                }
                Console.WriteLine("PRESSIONE --> F");
                if (Console.ReadKey(true).Key == ConsoleKey.F)
                {
                    Console.WriteLine("Boa!");
                }
                else
                {
                    Console.WriteLine("Você errou!");
                    return;
                }
                Console.WriteLine("Tempo esgotado! Você não digitou  a tempo.");
            }
        }

    }
}
