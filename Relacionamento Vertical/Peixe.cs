using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento_Vertical
{
    class Peixe : Animal, IPet
    {
        public override void Falar()
        {
            Console.WriteLine("Peixe: Falar() - GLUB GLUB");
        }

        public override void Respirar()
        {
            Console.WriteLine("Peixe: Respirar() - AGUA");
        }

        public void Tratar()
        {
            Console.WriteLine("Peixe: Tratar() - Limpar o vasilha...");
        }
    }
}
