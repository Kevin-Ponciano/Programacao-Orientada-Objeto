using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos
{
    class Aluno
    {
        public string Nome { get; set; }

        public string Matricula { get; set; }

        public Notas NotasDoAluno { get; set; }

        public List<Item> bolsaDeItens = new List<Item>();

        public Aluno(string nome, string matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }

        public void AdicionarItem(Item i)
        {
            bolsaDeItens.Add(i);
        }

        public void ListarTodosItens()
        {
            foreach (Item elem in bolsaDeItens)
            {
                Console.WriteLine($"{elem.Tipo}/ {elem.Qtd}");
            }

            /* Mesma coisa da linha 32 escrita de forma diferente.
             * 
             * bolsaDeItens.ForEach(elem => Console.WriteLine($"{elem.Tipo}/ {elem.Qtd}"));
             */
        }
    }
}
