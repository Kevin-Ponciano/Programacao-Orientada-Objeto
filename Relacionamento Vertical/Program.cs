using System;

namespace Relacionamento_Vertical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" == SerVivo ==");
            SerVivo sr = new SerVivo();
            sr.Nascer();
            sr.Crescer();
            sr.Morrer();

            Console.WriteLine(" == Animal ==");
            //            Animal an = new Animal();
            //an.Mover();
            //an.Respirar();
            //an.Nascer();
            //an.Crescer();
            //an.Morrer();


            Console.WriteLine(" == Peixe ==");
            Peixe px = new Peixe();
            px.Mover();
            px.Respirar();
            px.Nascer();
            px.Crescer();
            px.Morrer();
            px.Falar();
            px.Tratar();

            Console.WriteLine(" == Ave ==");
            Ave av = new Ave();
            av.Falar();
            //av.Tratar();


        }
    }
}
