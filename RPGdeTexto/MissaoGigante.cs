using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

internal class MissaoGigante
{
    public static void testeDoGigante()
    {
        while (true)
        {
            Console.WriteLine("Você tem 5 segundos para fazer os comandos!");
            Console.WriteLine("Pressione Enter para iniciar.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("M -> G -> F -> S");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<char> teclas = new List<char>();
            char proximaTecla = 'M';

            while (stopwatch.Elapsed.TotalSeconds < 5)
            {
                switch (proximaTecla)
                {
                    case 'M':
                        if (Console.ReadKey(true).Key == ConsoleKey.M)
                        {
                            Console.WriteLine("Boa! A força do gigante diminui para 70 e resistência para 60!");
                            teclas.Add('M');
                            proximaTecla = 'G';
                        }
                        break;
                    case 'G':
                        if (Console.ReadKey(true).Key == ConsoleKey.G)
                        {
                            Console.WriteLine("Boa! A força do gigante diminui para 50 e resistência para 40!");
                            teclas.Add('G');
                            proximaTecla = 'F';
                        }
                        break;
                    case 'F':
                        if (Console.ReadKey(true).Key == ConsoleKey.F)
                        {
                            Console.WriteLine("Boa! A força do gigante diminui para 30 e resistência para 20!");
                            teclas.Add('F');
                            proximaTecla = 'S';
                        }
                        break;
                    case 'S':
                        if (Console.ReadKey(true).Key == ConsoleKey.S)
                        {
                            Console.WriteLine("Boa! A força do gigante e resistência para 0!");
                            teclas.Add('S');
                            break;
                        }
                        break;
                }

                if (teclas.Count >= 4 && teclas[0] == 'M' && teclas[1] == 'G' && teclas[2] == 'F' && teclas[3] == 'S')
                {
                    Console.WriteLine("Você venceu a batalha!");
                    return;
                }
            }
            Console.WriteLine("Tempo esgotado. Você perdeu.");
            Console.WriteLine("Deseja tentar novamente? [s/n]");
            string resposta = Console.ReadLine().ToLower();
            if (resposta != "s")
            {
                return;
            }
        }
    }
}