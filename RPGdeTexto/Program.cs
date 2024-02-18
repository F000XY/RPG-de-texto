namespace RPGdeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parte de testes-----------------------------------------
            //Ataque.GerarNumeroAleatorio();




            //------------------------------------------------------
           
            while (true)
            {
                EscolhaPersonagem.escolhaMenu();
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
                        Console.WriteLine("");
                        guerreiro.Atributos();
                        guerreiro.Nome();
                        guerreiro.Sexo();
                        break;
                    case 2:
                        Mago mago = new Mago();
                        Console.WriteLine("");
                        mago.Atributos();
                        mago.Nome();
                        mago.Sexo();
                        break;
                    case 3:
                        Arqueiro arqueiro = new Arqueiro();
                        Console.WriteLine("");
                        arqueiro.Atributos();
                        arqueiro.Nome();
                        arqueiro.Sexo();
                        break;
                    case 4:
                        Clerigo clerigo = new Clerigo();
                        Console.WriteLine("");
                        clerigo.Atributos();
                        clerigo.Nome();
                        clerigo.Sexo();
                        break;
                    case 5:
                        Ladino ladino = new Ladino();
                        Console.WriteLine("");
                        ladino.Atributos();
                        ladino.Nome();
                        break;
                    case 6:
                        Druida druida = new Druida();
                        Console.WriteLine("");
                        druida.Atributos();
                        druida.Nome();
                        druida.Sexo();
                        break;
                    case 7:
                        Console.WriteLine("Deseja adicionar mais um personagem? (sim/não)");
                        string resposta = Console.ReadLine(); // Converter para minúsculas para facilitar a comparação
                        if (resposta == "sim")
                        {
                            Console.WriteLine("Adicionando mais um personagem...");
                            // Continue o loop para permitir que o usuário escolha mais um personagem
                            continue;
                        }
                        else if (resposta == "não")
                        {
                            Console.WriteLine("Ok! Personagens selecionados.");
                            // Saia do loop e encerre o programa
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Resposta inválida. Por favor, digite 'sim' ou 'não'.");
                            // Se a resposta não for 'sim' ou 'não', continue no loop para pedir novamente
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