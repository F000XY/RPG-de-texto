﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class Historia
    {
        public static void inicioHistoria() 
        {
            Console.Write("=-= O Despertar do Herói=-= \n Há muito tempo, em um reino chamado Eldoria, " +
                "as trevas começaram a se espalhar.\n Uma antiga profecia, " +
                "esquecida pelos habitantes do reino, ressurgiu das páginas empoeiradas " +
                "de pergaminhos sagrados. \n Dizia sobre heróis destinados a surgir nos " +
                "tempos de maior desespero, escolhidos e capazes de enfrentar as forças das \n trevas " +
                "e restaurar a paz em Eldoria.\n Você está pronto para encarar a aventura? Vamos criar" +
                " seu personagem: \n");
            Console.WriteLine("");
            Thread.Sleep(10000);
        }

        public static void inicioHistoriaAposCriacaoPersonagem()
        {
            Console.Write("\n Cada um desses heróis tem seu próprio destino entrelaçado com " +
                "o destino da cidade de Eldoria.\n Seus caminhos se cruzarão em meio a perigos " +
                "e desafios, mas juntos eles podem moldar o futuro desta terra de magia\n e mistério.\n" +
                " Agora, com os personagens prontos e seus destinos traçados, a verdadeira aventura está " +
                "prestes a começar em Eldoria.\n Prepare-se para desvendar os segredos dessa cidade encantada " +
                "e viver grandes aventuras ao lado de bravos heróis!");

            Console.WriteLine("\n Após andarem muito.. ");
            Thread.Sleep(20000);
            Console.WriteLine("\n Encontraram um velho sabio..");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public static void inicioHistoriaLojinha() 
        {
            Console.Write("\n Seguindo os conselhos de um velho sábio, eles logo encontram uma " +
                "pequena loja escondida em uma ruela estreita.");
            Thread.Sleep(5000);
            Console.WriteLine("");
            Console.Write("\n A lojinha, conhecida como 'Arcanos e Aventuras', é uma pequena e aconchegante tenda decorada com artefatos "+ 
                "mágicos\n e armas reluzentes.");
            Thread.Sleep(5000);
            Console.WriteLine("");
            Console.Write("\n Seu proprietário, um velho mago chamado Horácio, acolhe os " +
                "heróis com um sorriso sábio.\n");
            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.Write("\n =-=Horácio=-=: 'Sejam bem-vindos, nobres aventureiros, à minha humilde loja' " +
                " -Sua voz ecoando com um tom misterioso.\n ");
            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.Write("\n =-=Horácio=-=: 'Aqui vocês encontrarão uma vasta seleção de itens " +
                "mágicos e equipamentos poderosos para ajudá-los \n em suas jornadas pela terra de Eldoria.'");
            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.Clear();
        }

        public static void missaoEmEldoria()
        {
            Console.Write("\n Após se dispidirem de Horácio, e voltarem ao centro de Eldoria," +
                " perceberam uma grande agitação local.\n");
            Thread.Sleep(2000);
            Console.Write("\n Os heróis são informados sobre os desaparecimentos de aldeões na floresta próxima." +
            " Após um apelo dos próprios aldeões \n decidiram investigar o mistério.\n");
            Console.WriteLine(" ");
            Console.WriteLine("\n A entrada da floresta era marcada por dois enormes pinherios..");
            Thread.Sleep(2000);
            Console.WriteLine("    /\\           /\\     ");
            Console.WriteLine("   /  \\         /  \\    ");
            Console.WriteLine("  /    \\       /    \\   ");
            Console.WriteLine(" /      \\     /      \\  ");
            Console.WriteLine("/_______ \\   /_______ \\ ");
            Console.WriteLine("   |   |        |   |   ");
            Console.WriteLine("   |   |        |   |   ");
            Console.WriteLine(" ");
            Console.WriteLine("\n Nossos herois decidiram investigar esse misterio mais a fundo e adentraram na floresta..");
            Console.WriteLine(" ");
            Console.WriteLine("\n Pressione Enter para avançar na história...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n Nossos heróis decidiram investigar esse mistério mais a fundo e adentraram na floresta, " +
                "caminhando por entre as árvores imponentes que se erguiam ao seu redor. O chão estava coberto de " +
                "musgo úmido e folhas secas, criando um tapete natural \n que amortecia seus passos. Os raios de sol " +
                "filtravam-se timidamente através da densa copa das árvores, criando padrões \n de luz e sombra que " +
                 "dançavam pelo chão da floresta.\n");
            Console.WriteLine(" ");
            Console.WriteLine("\n Pressione Enter para avançar na história...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n O ar estava impregnado com o perfume fresco da vegetação, e o som suave do vento " +
                "sussurrava entre as folhas \n das árvores, criando uma melodia tranquilizadora. No entanto, " +
                "um sentimento de inquietude pairava no ar, \n como se a própria floresta estivesse aguardando " +
                "algo ou alguém.\n");
            Console.WriteLine(" ");
            Console.WriteLine("\n Pressione Enter para avançar na história...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n Enquanto avançavam mais fundo na floresta, os heróis começaram a notar " +
                "sinais de atividade incomum. \n Pegadas frescas de criaturas desconhecidas marcavam o chão " +
                "macio, e galhos quebrados indicavam que algo grande \n havia passado recentemente por ali.\n " +
                "Eles mantinham suas armas prontas e os sentidos aguçados, preparados para qualquer " +
                "desafio que pudessem \n encontrar em seu caminho.\n");
            Console.WriteLine(" ");
        }
    }
}
