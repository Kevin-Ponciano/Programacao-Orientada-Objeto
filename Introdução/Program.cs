using System;

namespace Introdução
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c01 = new Carro();
            c01.Modelo =  "Fusca";
            c01.Inventor = "Eu";

            Carro c02 = new Carro("Honda", "Js");

            Carro c03 = new Carro
            {
                Modelo = "Fusca",
                Inventor = "Eu",

            };

            Console.WriteLine($"c01.Modelo: {c01.Modelo}");
            Console.WriteLine($"c01.Inventor:{c01.Inventor}");
            c01.Acelerar(100);
            c01.Freiar();
        }
    }
}
