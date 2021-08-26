using System;

namespace Herancas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SerVivo");
            SerVivo sr = new SerVivo();
            sr.Nascer();
            sr.Crescer();
            sr.Morrer();
        }
    }
}
