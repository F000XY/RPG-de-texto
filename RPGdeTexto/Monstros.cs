using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGdeTexto
{
    internal class Monstros
    {
        public virtual void atributosMonstro()
        {
            int forca = 0;
            int resistencia = 0;
            int inteligencia = 0;
            int habilidade = 0;
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("RESISTÊNCIA: " + resistencia);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("HABILIDADE: " + habilidade);
           
        }
    }
    class Dragao : Monstros
    {
        public override void atributosMonstro()
        {
            Console.WriteLine("Criatura mistica e poderosa de grande porte, " +
                "possui sentidos aguçados, como visão noturna e olfato apurado");
            int forca = 90;
            int resistencia = 90;
            int inteligencia = 80;
            int habilidade = 90;
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("RESISTÊNCIA: " + resistencia);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("HABILIDADE: " + habilidade);

        }

    }
    class Gigante : Monstros
    {
        public override void atributosMonstro()
        {
            Console.WriteLine("Criatura imensa, com grande força e formidável resistencia, " +
                "possui baixa inteligência");
            int forca = 100;
            int resistencia = 80;
            int inteligencia = 50;
            int habilidade = 70;
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("RESISTÊNCIA: " + resistencia);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("HABILIDADE: " + habilidade);

        }
    }
    class Trolls : Monstros
    {
        public override void atributosMonstro()
        {
            Console.WriteLine(" Criatura resistente a danos físicos e ate mesmo mágicos, " +
                "inteligencia variavel, normalmente abixo da média");
            int forca = 80;
            int resistencia = 80;
            int inteligencia = 40;
            int habilidade = 60;
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("RESISTÊNCIA: " + resistencia);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("HABILIDADE: " + habilidade);

        }
    }
    class Goblins : Monstros
    {
        public override void atributosMonstro()
        {
            Console.WriteLine("Criatura de pequeno porte, força física modesta porém possui altas " +
                "habilidades de realizar armadilhas e emboscadas");
            int forca = 70;
            int resistencia = 70;
            int inteligencia = 60;
            int habilidade = 50;
            Console.WriteLine("FORÇA: " + forca);
            Console.WriteLine("RESISTÊNCIA: " + resistencia);
            Console.WriteLine("INTELIGENCIA: " + inteligencia);
            Console.WriteLine("HABILIDADE: " + habilidade);

        }

    }

}
