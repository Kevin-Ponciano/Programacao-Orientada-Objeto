using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
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
