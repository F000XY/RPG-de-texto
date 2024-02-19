using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class Personagem
    {
        public virtual void Atributos() 
        {
            Console.WriteLine("Esse personagem é especializado.");
            int forca = 0;
            int destreza = 0;
            int inteligencia = 0;
            int sabedoria = 0;
            int vida = 0;
            Console.WriteLine("Atributos do perrsonagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
        }
        public static string Nome()
        {
            Console.Write("Digite o nome do personagem: ");
            string nome = Console.ReadLine();
            return nome;
        }
        public static void Sexo ()
        {
            while (true)
            {
                Console.Write("Digite o sexo do personagem,'f' feminino ou 'm' masculino: ");
                string sexo = Console.ReadLine().ToLower();
                Console.WriteLine("");
                if (sexo == "m" || sexo == "f")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Não consegui identificar, tente novamente..");
                    continue;
                }
            }
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

    class Guerreiro : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("");
            Console.WriteLine("Esse personagem é especializado no combate corpo a corpo e possui " +
                "muitos atributos de defesa.");
            int forca = 100;
            int destreza = 50;
            int inteligencia = 10;
            int sabedoria = 50;
            int vida = 100;
            Console.WriteLine("Atributos do personagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
            Nome();
            Sexo();
            personagemCriado();
        } 
    }

    class Mago : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("");
            Console.WriteLine("Esse personagem é especializado no uso de magia" +
                " capaz de lançar feitiços muito poderosos.");
            int forca = 60;
            int destreza = 50;
            int inteligencia = 100;
            int sabedoria = 50;
            int vida = 20;
            Console.WriteLine("Atributos do personagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
            Nome();
            Sexo();
            personagemCriado();
     
        }
 
    }
    class Ladino : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("");
            Console.WriteLine("Esse personagem é especializado em furtividade, " +
                "especializado em desarmar os oponentes.");
            int forca = 50;
            int destreza = 100;
            int inteligencia = 50;
            int sabedoria = 50;
            int vida = 50;
            Console.WriteLine("Atributos do personagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
            Nome();
            Sexo();
            personagemCriado();

        }

    }
    class Clerigo : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("");
            Console.WriteLine("Esse personagem é especializado no poder de cura " +
                "para proteger e realizar milagres.");
            int forca = 50;
            int destreza = 50;
            int inteligencia = 50;
            int sabedoria = 100;
            int vida = 50;
            Console.WriteLine("Atributos do personagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
            Nome();
            Sexo();
            personagemCriado();
           
        }

    }
    class Arqueiro : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("");
            Console.WriteLine("Esse personagem é especializado no combate á distância " +
                "com arco e flechas.");
            int forca = 50;
            int destreza = 100;
            int inteligencia = 50;
            int sabedoria = 50;
            int vida = 50;
            Console.WriteLine("Atributos do personagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
            Nome();
            Sexo();
            personagemCriado();
         
        }
 
    }
    class Druida : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("");
            Console.WriteLine("Esse personagem é especializado na natureza," +
                " possui habilidades de comunicação com plantas e animais.");
            int forca = 50;
            int destreza = 50;
            int inteligencia = 50;
            int sabedoria = 100;
            int vida = 50;
            Console.WriteLine("Atributos do personagem: ");
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("DESTREZA: " + destreza);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("SABEDORIA: " + sabedoria);
            Console.WriteLine("VIDA: " + vida);
            Nome();
            Sexo();
            personagemCriado();
         
        }

    }
}
