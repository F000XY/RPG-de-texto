using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGdeTexto
{
    internal class Menus
    {
       public static void escolhaMenu()
       {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("BEM-VINDO A CRIAÇÃO DE PERSONAGEM");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("");
            Console.WriteLine("1. Guerreiro");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Arqueiro");
            Console.WriteLine("4. Clerigo");
            Console.WriteLine("5. Ladino");
            Console.WriteLine("6. Druida");
            Console.WriteLine("7. Adicionar outro personagem ");
            Console.Write("Digite o número desejado: "); 
       }

        public static void escolhaLojinha()
        {
            while (true)
            {
                Console.WriteLine("Escolha um personagem com sabedoria jovem guerreiro!");
                Console.WriteLine("1. Poção Cura");
                Console.WriteLine("2. Poção Força");
                Console.WriteLine("3. Poção Veneno");

                Console.WriteLine("4. Machado Obsidiana Negra");
                Console.WriteLine("5. Arco Lapis Lazuli");
                Console.WriteLine("6. Espada de Prisma");

                Console.WriteLine("7. Túnica Arcana");
                Console.WriteLine("8. Placas de Batalha");

                Console.WriteLine("9. Cajado da Cura Eterna");
                Console.WriteLine("10. Orbe da Natureza Ancestral");
                Console.WriteLine("11. Livro dos Arcanos Antigos");
                Console.Write("Digite o número desejado: ");

                int escolhaitem;
                //LADINO
                int forcaLadino = 50;
                int forcaMachado = 60;
                //ARQUEIRO
                int forcaArqueiro = 50;
                int forcaArco = 70;
                //GUERREIRO
                int forcaGuerreiro = 100;
                int forcaEspada = 80;
                //DRUIDA
                int forcaDruida = 50;
                int forcaOrbe = 35;
                //MAGO
                int forcaMago = 60;
                int forcaLivro = 35;
                //CLERIGO
                int forcaClerigo = 50;
                int vidaClerigo = 50;
                //ITEMS
                int forcaPlacas = 20;
                int forcaTunica = 20;

                if (!int.TryParse(Console.ReadLine(), out escolhaitem)) { }
                switch (escolhaitem)
                {
                    case 1:
                        Console.WriteLine("Você selecionou: Poção Cura");
                        break;
                    case 2:
                        Console.WriteLine("Você selecionou: Poção Força");
                        break;
                    case 3:
                        Console.WriteLine("Você selecionou: Poção Veneno");
                        break;
                    case 4:
                        Console.WriteLine("Você selecionou: Machado Obsidiana Negra");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemLadino = Console.ReadLine().ToLower();
                        if (itemLadino == "ladino")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaLadino + forcaMachado;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é ladino, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                       
                    case 5:
                        Console.WriteLine("Você selecionou: Arco Lapis Lazuli");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemArqueiro = Console.ReadLine().ToLower();
                        if (itemArqueiro == "arqueiro")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaArqueiro + forcaArco;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é arqueiro, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                    case 6:
                        Console.WriteLine("Você selecionou: Espada de Prisma");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemGuerreiro = Console.ReadLine().ToLower();
                        if (itemGuerreiro == "guerreiro")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaGuerreiro + forcaEspada;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é arqueiro, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                    case 7:
                        Console.WriteLine("Você selecionou: Túnica Arcana");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemMagico = Console.ReadLine().ToLower();
                        if (itemMagico == "mago")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaMago + forcaTunica;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else if (itemMagico == "clerigo")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaClerigo + forcaTunica;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else if (itemMagico == "druida")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaDruida + forcaTunica;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é personagem magico, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                    case 8:
                        Console.WriteLine("Você selecionou: Placas de Batalha");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemGuerreiros = Console.ReadLine().ToLower();
                        if (itemGuerreiros == "guerreiro")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaGuerreiro + forcaPlacas;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else if (itemGuerreiros == "arqueiro")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaArqueiro + forcaPlacas;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else if (itemGuerreiros == "ladino")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaLadino + forcaPlacas;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é personagem de guerra, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                    case 9:
                        Console.WriteLine("Você selecionou: Cajado da Cura Eterna");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemClerigo = Console.ReadLine().ToLower();
                        if (itemClerigo == "clerigo")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int vidaCajado = 55;
                            int soma = vidaClerigo + vidaCajado;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é clerigo, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                    case 10:
                        Console.WriteLine("Você selecionou: Orbe da Natureza Ancestral");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemDruida = Console.ReadLine().ToLower();
                        if (itemDruida == "druida")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaDruida + forcaOrbe;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é druida, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }

                    case 11:
                        Console.WriteLine("Você selecionou: Livro dos Arcanos Antigos");
                        Console.Write("Digite a categoria do seu personagem: ");
                        var itemMago = Console.ReadLine().ToLower();
                        if (itemMago == "mago")
                        {
                            Console.Clear();
                            Console.WriteLine("Compra confirmada!");
                            int soma = forcaMago + forcaLivro;
                            Console.WriteLine("Seus atributos de força subiram para: " + soma);
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ou você não é mago, ou digitou errado..");
                            Console.WriteLine("");
                            continue;
                        }
                    default:

                        break;
                }
            }
        }              
    }
}
