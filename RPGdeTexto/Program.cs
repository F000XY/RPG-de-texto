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
                        break;
                    case 2:
                        Mago mago = new Mago();
                        mago.Atributos();
                        break;
                    case 3:
                        Arqueiro arqueiro = new Arqueiro();
                        arqueiro.Atributos();
                        break;
                    case 4:
                        Clerigo clerigo = new Clerigo();
                        clerigo.Atributos();
                        break;
                    case 5:
                        Ladino ladino = new Ladino();
                        ladino.Atributos();
                        break;
                    case 6:
                        Druida druida = new Druida();
                        druida.Atributos();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Deseja adicionar mais um personagem? (s/n)");
                        string resposta = Console.ReadLine().ToLower();
                        if (resposta == "s")
                        {
                            Console.WriteLine("Adicionando mais um personagem...");
                            // Continue o loop para permitir que o usuário escolha mais um personagem
                            continue;
                        }
                        else if (resposta == "n")
                        {
                            Console.WriteLine("Ok! Personagens selecionados.");
                            if (resposta== "n") 
                            {
                                Lojinha.ApresentarTudo(); 
                            }
                            return; 
                        }
                        else
                        {
                            Console.WriteLine("Resposta inválida. Por favor, digite 's' ou 'n'.");
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