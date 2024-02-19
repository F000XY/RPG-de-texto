using System.Runtime.CompilerServices;

namespace RPGdeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parte de testes-----------------------------------------
            //Ataque.GerarNumeroAleatorio();
            //Historia.inicioHistoria();
            //Lojinha.ApresentarTudo();
            // Menus.escolhaLojinha();
            //int escolhaitem;
            //if (!int.TryParse(Console.ReadLine(), out escolhaitem))
            // {
            // Console.Clear();

            //}

            //------------------------------------------------------
            Historia.inicioHistoria();
            List<string> personagensLista = new List<string>();
            //criei uma lista apenas de exibição para os att dos personagens passivel de mudança.
            while (true)
            {
                Menus.escolhaMenu();
                int escolha;
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Por favor, digite um número válido.");
                    continue;
                    // loopando no caso de letras erradas
                }
                switch (escolha)
                {
                    case 1:
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Atributos();
                        personagensLista.Add("Dados: Gerreiro, F=100, D=50, I=10, S=50, V=100.");
                        break;
                    case 2:
                        Mago mago = new Mago();
                        mago.Atributos();
                        personagensLista.Add("Dados: Mago, F=60, D=50, I=100, S=50, V=20.");
                        break;
                    case 3:
                        Arqueiro arqueiro = new Arqueiro();
                        arqueiro.Atributos();
                        personagensLista.Add("Dados: Arqueiro, F=50, D=100, I=50, S=50, V=50.");
                        break;
                    case 4:
                        Clerigo clerigo = new Clerigo();
                        clerigo.Atributos();
                        personagensLista.Add("Dados: Clérigo, F=50, D=50, I=100, S=50, V=50.");
                        break;
                    case 5:
                        Ladino ladino = new Ladino();
                        ladino.Atributos();
                        personagensLista.Add("Dados: Ladino, F=50, D=100, I=50, S=50, V=50.");
                        break;
                    case 6:
                        Druida druida = new Druida();
                        druida.Atributos();
                        personagensLista.Add("Dados: Druida, F=50, D=50, I=100, S=50, V=50.");
                            break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Deseja adicionar mais um personagem? (s/n)");
                        string resposta = Console.ReadLine().ToLower();
                        if (resposta == "s")
                        {
                            Console.WriteLine("Adicionando mais um personagem...");
                            continue;
                        }
                        else if (resposta == "n")
                        {
                            Console.WriteLine("Ok! Personagens selecionados. Confira a lista: ");
                            if (resposta== "n") 
                            {   
                                foreach (var personagem in personagensLista){ Console.WriteLine(personagem); }
                            }
                            Historia.inicioHistoriaAposCriacaoPersonagem();
                            Historia.inicioHistoriaLojinha();
                            Lojinha.ApresentarTudo();
                            Menus.escolhaLojinha();
                            int escolhaitem;
                            if (!int.TryParse(Console.ReadLine(), out escolhaitem)){ }
                            
                            return; 
                        }
                        else
                        {
                            Console.WriteLine("Resposta inválida. Por favor, digite 's' ou 'n'.");
                            continue;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Por favor, digite um número válido.");
                        // numeros errados 
                        break;
                }
                
            }

        }
    }
}