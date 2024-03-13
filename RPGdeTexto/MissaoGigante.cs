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

        // Mensagem final
        Console.WriteLine("GOOOOOOO!!");
        Console.Clear();
        Stopwatch stopwatch = new Stopwatch();
        // Inicia o contador
        stopwatch.Start();
        Console.WriteLine("M -> G -> F");

        // Variáveis para armazenar se as teclas foram pressionadas corretamente
        bool mPressionado = false, gPressionado = false, fPressionado = false;

        while (stopwatch.ElapsedMilliseconds < 5000)
        {
            if (!mPressionado && Console.KeyAvailable && Console.ReadKey(true).
                Key == ConsoleKey.M)
            {
                mPressionado = true;
                Console.WriteLine("Boa! M");
            }
            else if (!gPressionado && Console.KeyAvailable && Console.ReadKey(true).
                Key == ConsoleKey.G)
            {
                gPressionado = true;
                Console.WriteLine("Boa! G");
            }
            else if (!fPressionado && Console.KeyAvailable && Console.ReadKey(true).
                Key == ConsoleKey.F)
            {
                fPressionado = true;
                Console.WriteLine("Boa! F");
            }

            // Se todas as teclas foram pressionadas, encerra o loop
            if (mPressionado && gPressionado && fPressionado)
            {
                break;
            }
        }

        // Verifica se todas as teclas foram pressionadas dentro do tempo limite
        if (mPressionado && gPressionado && fPressionado)
        {
            Console.WriteLine("Você venceu a batalha!");
        }
        else
        {
            Console.WriteLine("Tempo esgotado ou tecla errada!");
        }
    }
}