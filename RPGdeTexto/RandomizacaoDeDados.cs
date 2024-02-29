using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
           // int numero = RandomizacaoDeDados.GerarNumeroAleatorio();
            int numero = 1;
            while (true)
            {
                Console.WriteLine("\n Você deseja lutar contra o dragão? (S/N) ");
                string lutar = Console.ReadLine().ToLower();
                if (lutar == "s")
                {
                    Console.WriteLine("Bora batalhar! Digite D para testar sua sorte! ");
                    string dado = Console.ReadLine().ToLower();

                    if (dado == "d")
                    {
                        switch (numero)
                        {
                            case 1:
                                Console.WriteLine("Para o seu azar seu numero foi de de: " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 2:
                                Console.WriteLine("Para o seu azar seu numero foi de de: " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 3:
                                Console.WriteLine("Para o seu azar seu numero foi de de: " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 4:
                                Console.WriteLine("Para o seu azar seu numero foi de de: " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 5:
                                Console.WriteLine("Para o seu azar seu numero foi de de: " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                         (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 6:
                                Console.WriteLine("Para o seu azar seu numero foi de de: " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 7:
                                Console.WriteLine("Vocês tiraram " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 8:
                                Console.WriteLine("Vocês tiraram " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 9:
                                Console.WriteLine("Vocês tiraram " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 10:
                                Console.WriteLine("Vocês tiraram " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 11:
                                Console.WriteLine("Vocês tiraram " + numero);
                                Console.WriteLine("As poções são usadas automaticamente para ajudar na missão.");
                                Console.WriteLine("=-=Poção de Cura=-= Aumento temporario da sua saúde em: +50 ");
                                Console.WriteLine("=-=Poção de Força=-= Aumento temporario de força em: +100 ");
                                Console.WriteLine("=-=Poção de Veneno=-= Diminuida a vida do dragão em: -50 ");
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 12:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 13:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                     (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 14:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                     (@"
                                                                   *_
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__**
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 15:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 16:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 17:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 18:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                        (@"
                                                                   ****
                                                                  /._)
                                                         _.----._/ /
                                                       /          ***
                                                    __/ (  | *   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 19:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                       (@"
                                                                   *****
                                                                  /._)
                                                         _.----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                                ******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");

                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            case 20:
                                Console.WriteLine("Seu numero da sorte foi de: " + numero);
                                Console.WriteLine
                                      (@"
                                                                   __
                                                                  /._)
                                                         _.----._/ /
                                                       /          \
                                                    __/ (  |  (   |
                                                   /__.-'|_|--|__|
                                      ");
                               
                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                                   *****
                                                                  /._)
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|_|--|__|
                                      ");
                             
                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  **----._/ /
                                                       /            ****
                                                    __/ (  | **   |
                                               *******_.-'|***--******
                                      ");
                            
                                Console.WriteLine(" ");
                                Console.WriteLine("\n Pressione Enter para bater no dragão...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine
                                      (@"
                                                            ***       *****
                                                                  *******
                                                    ***  *********
                                                       ***            ****
                                                    *** **  **   *
                                               *******  ***  ******
                                      ");
                                Console.WriteLine("\n O Dragão foi morto");
                                break;
                            default:
                                Console.WriteLine("Vocês tiraram um número fora do esperado.");
                                break;
                        }

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
                    continue;
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