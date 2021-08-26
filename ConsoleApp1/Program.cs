using System;

namespace Relacionamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno01 = new Aluno("kevin", "123456");

            Console.WriteLine($"aluno01.Nome: {aluno01.Nome}" +
                $" aluno01.Matricula: {aluno01.Matricula}");

            Console.WriteLine("Digite as duas notas da disciplina:");
            Notas notasAtuais = new Notas(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            notasAtuais.DefinirStatus();

            aluno01.NotasDoAluno = notasAtuais;
            Console.WriteLine($"{aluno01.NotasDoAluno.Status}");

            Item i01 = new Item
            {
                Tipo = "Borracha",
                Qtd = 10
            };

            aluno01.AdicionarItem(i01);

            Console.WriteLine("Listando os Itens");
            aluno01.ListarTodosItens();
        }
    }
}