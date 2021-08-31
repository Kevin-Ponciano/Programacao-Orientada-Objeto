using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento_Vertical
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
