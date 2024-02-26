using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class RandomizacaoDeDados
    {

        public static int GerarNumeroAleatorio()
        {
            Random random = new Random();
            // Gerando um número aleatório entre 1 e 20
            int numeroAleatorio = random.Next(1, 21);
            return numeroAleatorio; 
        }

    }
    class Ataque : RandomizacaoDeDados
    {
        public static void luta()
        {
            while (true) 
            { 
                Console.WriteLine("Você deseja lutar contra o dragão? (S/N) ");
                string lutar = Console.ReadLine().ToLower();
                if (lutar == "s")
                {
                    Console.WriteLine("Bora batalhar! Digite D para testar sua sorte! ");
                    string dado = Console.ReadLine().ToLower();

                    if (dado == "d")
                    {
                        int numero = GerarNumeroAleatorio();
                        Console.WriteLine("Seu numero da sorte (ou não) foi de: " + numero);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Não entendi o que você digitou tente de novo!");
                        continue;
                    }
                }
                else if (lutar == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Vai arregar mesmo? \n");
                    Console.WriteLine("Digita sim logo,se nao vamos ficar aqui o dia todo!\n");
                     continue ;
                }
                else
                {
                    Console.WriteLine("Não entendi o que você digitou tente de novo!");
                    continue;
                }
            }      
        }
    }

}