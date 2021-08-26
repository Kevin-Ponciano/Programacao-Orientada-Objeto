using System;

namespace Introdução
{
    class Carro
    {
        public string Modelo { get; set; }
        public string Inventor { get; set; }
        public Carro()
        {

        }
        public Carro(string model, string invent)
        {
            this.Inventor = invent;
            this.Modelo = model;
        }
        public void Acelerar(int velo)
        {
            Console.WriteLine($"A velocidade de aceleração é {velo}");
        }
        public void Freiar()
        {
            Console.WriteLine("Freiando...");
        }
    }
}
