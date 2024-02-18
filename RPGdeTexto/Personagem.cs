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
        public void Nome()
        {
            Console.Write("Digite o nome do personagem: ");
            string nome = Console.ReadLine();
        }
        public void Sexo ()
        {
            while (true)
            {
                Console.Write("Digite o sexo do personagem, feminino ou masculino: ");
                string sexo = Console.ReadLine();
                Console.WriteLine("");
                if (sexo == "masculino" || sexo == "feminino")
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

    }

    class Guerreiro : Personagem
    {
        public override void Atributos()
        {
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
        }

    }

    class Mago : Personagem
    {
        public override void Atributos()
        {
            Console.WriteLine("Esse personagem é especializado no uso de magia" +
                " capaz de lançar feitiços muito poderosos.");
            int forca = 10;
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
        }
 
}
    class Ladino : Personagem
    {
        public override void Atributos()
        {
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
        }

    }
    class Clerigo : Personagem
    {
        public override void Atributos()
        {
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
        }

    }
    class Arqueiro : Personagem
    {
        public override void Atributos()
        {
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
        }
 
    }
    class Druida : Personagem
    {
        public override void Atributos()
        {
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
        }

    }
}
