using System.Runtime.CompilerServices;

namespace RPGdeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                        var nomeG= Personagem.Nome();
                        var sexoG= Personagem.Sexo();
                        int[] vetorG = { 100, 50, 10, 50, 100 };
                        personagensLista.Add("Dados: Guerreiro (" +nomeG+ "," +sexoG+ ") F=" + vetorG[0] + " D=" +vetorG[1]+ " I=" + vetorG[2]+ " S=" +vetorG[3]+ " V=" + vetorG[4]);
                        Personagem.personagemCriado();
                        break;
                    case 2:
                        Mago mago = new Mago();
                        mago.Atributos();
                        var nomeM = Personagem.Nome();
                        var sexoM = Personagem.Sexo();
                        int[] vetorM = { 60, 50, 100, 50, 20 };
                        personagensLista.Add("Dados: Mago (" +nomeM+ "," +sexoM+ ") F=" + vetorM[0] + " D=" + vetorM[1] + " I=" + vetorM[2] + " S=" + vetorM[3] + " V=" + vetorM[4]);
                        Personagem.personagemCriado();
                        break;
                    case 3:
                        Arqueiro arqueiro = new Arqueiro();
                        arqueiro.Atributos();
                        var nomeA = Personagem.Nome();
                        var sexoA = Personagem.Sexo();
                        int[] vetorA = { 50, 100, 50, 50, 50 };
                        personagensLista.Add("Dados: Arqueiro (" + nomeA + "," + sexoA + ") F=" + vetorA[0] + " D=" + vetorA[1] + " I=" + vetorA[2] + " S=" + vetorA[3] + " V=" + vetorA[4]);
                        Personagem.personagemCriado();
                        break;
                    case 4:
                        Clerigo clerigo = new Clerigo();
                        clerigo.Atributos();
                        var nomeC = Personagem.Nome();
                        var sexoC = Personagem.Sexo();
                        int[] vetorC = { 50, 50, 100, 50, 50 };
                        personagensLista.Add("Dados: Clérigo (" + nomeC + "," + sexoC + ") F=" + vetorC[0] + " D=" + vetorC[1] + " I=" + vetorC[2] + " S=" + vetorC[3] + " V=" + vetorC[4]);
                        Personagem.personagemCriado();
                        break;
                    case 5:
                        Ladino ladino = new Ladino();
                        ladino.Atributos();
                        var nomeL = Personagem.Nome();
                        var sexoL = Personagem.Sexo();
                        int[] vetorL = { 50, 100, 50, 50, 50 };
                        personagensLista.Add("Dados: Ladino (" + nomeL + "," + sexoL + ") F=" + vetorL[0] + " D=" + vetorL[1] + " I=" + vetorL[2] + " S=" + vetorL[3] + " V=" + vetorL[4]);
                        Personagem.personagemCriado();
                        break;
                    case 6:
                        Druida druida = new Druida();
                        druida.Atributos();
                        var nomeD = Personagem.Nome();
                        var sexoD = Personagem.Sexo();
                        int[] vetorD = { 50, 50, 100, 50, 50 };
                        personagensLista.Add("Dados: Druida (" + nomeD + "," + sexoD + ") F=" + vetorD[0] + " D=" + vetorD[1] + " I=" + vetorD[2] + " S=" + vetorD[3] + " V=" + vetorD[4]);
                        Personagem.personagemCriado();
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
                            if (personagensLista.Count == 0)
                            {
                               Console.WriteLine("Não há personagens criados ainda. Por favor, crie pelo menos um personagem antes de prosseguir.");
                               Console.WriteLine("");
                                continue;
                            }
                            Console.WriteLine("Ok! Personagens selecionados. Confira a lista: ");
                            if (resposta== "n") 
                            {   
                                foreach (var personagem in personagensLista){ Console.WriteLine(personagem); }
                               
                            }
                          //  Historia.inicioHistoriaAposCriacaoPersonagem();
                          //  Historia.inicioHistoriaLojinha();
                            Lojinha.ApresentarTudo();
                            Menus.escolhaLojinha();
                            Historia.missaoEmEldoria();


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