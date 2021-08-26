using System;

namespace Exercicios_Introdução
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota notas = new Nota(8, 9);

            Console.WriteLine($"notas.Status: {notas.Status}");
            notas.definirStatus();

            Console.WriteLine($"Media das notas: {notas.Media}");
            Console.WriteLine($"Status de Aprovação: {notas.Status}");
            
        }
    }
}
