using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class MissaoCandyT
    {
        public static void caminhos()
        {
            Console.WriteLine("Aqui em Candy Town, cidade bela e açucarada, nossos herois se deparam com caminhos que mais parecem" +
                "labirintos, o nosso objetvo é chegar no castelo será que venceremos essa trilha?");
            Console.WriteLine("Cada encruzilhada possuirá alguns caminhos e cabe a vocês jovens sabios escolher a trilha.. com sorte chegaram ao" +
                "castelo");
        }
        public static void caminhos2()
        {
            while (true)
            {
                Console.WriteLine("Vamos começar.. temos duas trilhas a seguir, 1 - Caminho da Bala 2- Caminho do Chiclete.. decida-se");
                int escolha;
                if (!int.TryParse(Console.ReadLine(), out escolha)) { }
                if (escolha == 1)
                {
                    Console.WriteLine("Uma boa escolha o Caminho da Bala é mais eficiente que do Chiclete, durante a luz do dia o Chiclete torna-se" +
                        "pegajoso e ruim para andar");
                    Console.WriteLine("Chegamos ao final do Caminho da Bala com louvor");
                    return;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Uma escolha não tão sabia! Tome cuidado para não ficar preso no chiclete..");
                    Console.WriteLine("Após andar o sol começou a derreter o chiclete e grudar em seus pés..O que fazer?");
                    Console.WriteLine("DICA: Poção de veneno é corrosiva! Digite 1- Usar poção, 2- Usar suas armas.");
                    int escolhaChiclete;
                    if (!int.TryParse(Console.ReadLine(), out escolhaChiclete)) { }
                    if (escolhaChiclete == 1) { Console.WriteLine("Você conseguiu!! Chegou ao final do Caminho do Chiclete!"); }
                    else if (escolhaChiclete == 2) { Console.WriteLine("Você conseguiu por pouco!! Chegou ao final do Caminho do Chiclete! Agora descanse"); }
                    return;
                }
                else
                {
                    Console.WriteLine("Não entendi! Tente de novo!!");
                }
            }

        }
        public static void caminhos3()
        {
            while (true)
            {
                Console.WriteLine("Vamos continuar.. Agora temos a decisão entre 1- Caminho dos Pirulitos, 2- Caminho do Marshmallow");
                int escolha;
                if (!int.TryParse(Console.ReadLine(), out escolha)) { }
                if (escolha == 1)
                {
                    Console.WriteLine("Uma boa escolha o Caminho dos Pirulitos é mais eficiente que do Marshmallow, durante a luz do dia o Marshmallow torna-se" +
                        "pegajoso e ruim para andar");
                    Console.WriteLine("Chegamos ao final do Caminho dos Pirulitos com louvor");
                    return ;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Uma escolha não tão sabia! Tome cuidado para não ficar preso no Marshmallow..");
                    Console.WriteLine("Após andar o sol começou a derreter o Marshmallow e grudar em seus pés..O que fazer?");
                    Console.WriteLine("DICA: Poção de veneno é corrosiva! Digite 1- Usar poção, 2- Usar suas armas.");
                    int escolhaMarsh;
                    if (!int.TryParse(Console.ReadLine(), out escolhaMarsh)) { }
                    if (escolhaMarsh == 1) { Console.WriteLine("Você conseguiu!! Chegou ao final do Caminho do Chiclete!"); }
                    else if (escolhaMarsh == 2) { Console.WriteLine("Você conseguiu por pouco!! Chegou ao final do Caminho do Chiclete! Agora descanse"); }
                    return ;
                }
                else
                {
                    Console.WriteLine("Não entendi! Tente de novo!!");
                }
            }
        }
        public static void caminhos4() 
        {
            while (true)
            {
                Console.WriteLine("Chegamos ao final, já é possivel ver o castelo.. Antes de entrar no castelo o guarda aborda ..");
                Console.WriteLine("=-=Guarda=-=: 'Quem lá vem, la vai o caminhos revelam uma senha de 4 digitos e dois pares vão formar.." +
                    "me diga para entrar!'");
                Console.WriteLine();
                int senha; 
                if (!int.TryParse(Console.ReadLine(), out senha)) { }
                if (senha == 1212) { Console.WriteLine("=-=Guarda=-=: 'Seja bem vindo aventurero'"); Console.WriteLine(); return; }
                else { Console.WriteLine("=-= Guarda =-=: 'Essa não é a senha aventureiro'"); Console.WriteLine(); continue; }

            }
        }
    }
}
