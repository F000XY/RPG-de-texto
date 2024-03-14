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
        Console.WriteLine("Pressione as teclas corretas dentro de 5 segundos:");
        // Contador regressivo
        for (int i = 5; i >= 1; i--)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Começaremos em {i} segundos!!");
        }
        Console.WriteLine("GOOOOOOO!!");
        Console.Clear();
        // Inicia o contador
        Stopwatch stopwatch = new Stopwatch();   
        stopwatch.Start();
        Console.WriteLine("M -> G -> F -> S");

        // Variáveis para armazenar se as teclas foram pressionadas corretamente
        bool mPressionado = false, gPressionado = false, fPressionado = false, sPressionado = false, dPressionado = false;

        char proximaTecla = 'M'; 

        while (true)
        {
            ConsoleKeyInfo teclaPressionada = Console.ReadKey(true);

            switch (proximaTecla)
            {
                case 'M':
                    if (teclaPressionada.Key == ConsoleKey.M)
                    {
                        mPressionado = true;
                        Console.WriteLine("Boa! A força do gigante diminui para 70 e resistência para 60!");
                    proximaTecla = 'G';
                    }
                   break;
                case 'G':
                    if (teclaPressionada.Key == ConsoleKey.G)
                    {
                        gPressionado = true;
                        Console.WriteLine("Boa! A força do gigante diminui para 50 e resistência para 40!");
                        proximaTecla = 'F';
                    }
                    break;
                case 'F':
                    if (teclaPressionada.Key == ConsoleKey.F)
                    {
                        fPressionado = true;
                        Console.WriteLine("Boa! A força do gigante diminui para 30 e resistência para 20!");
                        proximaTecla = 'S';
                    }
                    break;
                case 'S':
                    if (teclaPressionada.Key == ConsoleKey.S)
                    {
                        sPressionado = true;
                        Console.WriteLine("Boa! A força do gigante e resistência para 0!");
                        proximaTecla = 'D';
                       
                    }
                    break;
                default:
                    if (mPressionado && gPressionado && fPressionado && dPressionado)
                    {
                        Console.WriteLine("Você venceu a batalha!");
                        return;
                    }
                    else if (stopwatch.ElapsedMilliseconds >= 5000)
                    {
                        Console.WriteLine("Tempo esgotado!");
                        Console.WriteLine("Deseja tentar novamente? [s/n] ");
                        string resposta = Console.ReadLine().ToLower();
                        if (resposta == "s")
                        {
                            continue;
                        }
                        if (resposta == "n")
                        {
                            Console.WriteLine("Você ira sair do jogo, tem certeza? [s/n] O progresso será perdido! ");
                            string resposta2 = Console.ReadLine().ToLower();
                            if (resposta == "s")
                            {
                                return;
                            }
                            if (resposta == "n")
                            {
                                Console.WriteLine("Vamos tentar novamente então!");
                                continue;
                            }
                        }
                    }
                 
                  
                    break;
  
                }
           
        }

       
        
    }
}
