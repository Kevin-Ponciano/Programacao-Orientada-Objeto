using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class SerVivo
    {
        public int Tamanho { get; set; }

        public void Nascer()
        {
            Console.WriteLine("SerVivo: Nascer()");
        }

        public void Crescer()
        {
            Console.WriteLine("SerVivo: Crescer()");
        }

        public void Morrer()
        {
            Console.WriteLine("SerVivo: Morrer()");
        }
    }
}
