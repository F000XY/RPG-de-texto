using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGdeTexto
{
    internal class EscolhaPersonagem
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
        public static void personagemCriado() 
        {
            Console.WriteLine("");
            Console.WriteLine("Criando personagem...");
            Thread.Sleep(2000);
            Console.WriteLine("O personagem foi criado com sucesso!!");
            Thread.Sleep(2000);
            Console.Clear();

        }
    }
}
