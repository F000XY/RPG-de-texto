using System;
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
        }

        public static void inicioHistoriaAposCriacaoPersonagem()
        {
            Console.Write("\n Cada um desses heróis tem seu próprio destino entrelaçado com " +
                "o destino da cidade de Eldoria.\n Seus caminhos se cruzarão em meio a perigos " +
                "e desafios, mas juntos eles podem moldar o futuro desta terra de magia\n e mistério.\n" +
                " Agora, com os personagens prontos e seus destinos traçados, a verdadeira aventura está " +
                "prestes a começar em Eldoria.\n Prepare-se para desvendar os segredos dessa cidade encantada " +
                "e viver grandes aventuras ao lado de bravos heróis!");
            Console.Clear();
            Console.WriteLine("Após andarem muito.. ");
            Thread.Sleep(2000);
            Console.WriteLine("Encontraram um velho sabio..");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public static void inicioHistoriaLojinha() 
        {
            Console.Write("\n Seguindo os conselhos de um velho sábio, eles logo encontram uma " +
                "pequena loja escondida em uma ruela estreita.");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write("\n A lojinha, conhecida como 'Arcanos e Aventuras', é uma pequena e aconchegante tenda decorada com artefatos "+ 
                "mágicos\n e armas reluzentes.");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write("\n Seu proprietário, um velho mago chamado Horácio, acolhe os " +
                "heróis com um sorriso sábio.\n");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.Write("\n =-=Horácio=-=: 'Sejam bem-vindos, nobres aventureiros, à minha humilde loja' " +
                " sua voz ecoando com um tom misterioso.\n ");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.Write("\n =-=Horácio=-=: 'Aqui vocês encontrarão uma vasta seleção de itens " +
                "mágicos e equipamentos poderosos para ajudá-los \n em suas jornadas pela terra de Eldoria.'");
            Console.WriteLine("");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
