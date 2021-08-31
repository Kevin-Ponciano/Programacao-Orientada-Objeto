using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento_Vertical
{
    abstract class Animal : SerVivo
    {
        public void Mover()
        {
            Console.WriteLine("Animal: Mover()");
        }

        public virtual void Respirar()
        {
            Console.WriteLine("Animal: Respirar() - AR");
        }

        //        public virtual void Falar()
        //        {
        //            Console.WriteLine("Animal: Falar() - ?????????");
        //        }

        public abstract void Falar();

    }
}
