using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2
{

    class Loja
    {
        private List<Pedido> listaPedidos;

        public List<Pedido> ListaPedidos { //Propriedade serve apenas pra devolver um valor
            get
            {
                return listaPedidos;
            }
        }

        public Loja()
        {
            listaPedidos = new List<Pedido>();
        }

        public Funcionario funcionario;

        public void inserirPedido(Pedido pedido)
        {
            // localizar o X, tal que a propriedade PedidoId seje igual ao PedidoId do pedido
            // caso ache o valor significa que ja tem o codigo registrado
            Pedido p = listaPedidos.Find(x => x.PedidoId == pedido.PedidoId);
            if(p == null)
            {
                listaPedidos.Add(pedido);
                Console.WriteLine("Pedido adicionado...");

            }
            else
            {
                Console.WriteLine("Id ja cadastrado");
            }
        }

        public void buscarPedido(int id)
        {
            Pedido p = listaPedidos.Find(x => x.PedidoId == id);
            if (p != null)
            {
                Console.Write($"\nID: {p.PedidoId} \nData: {p.DataEmissao} \nValor: {p.ValorDoProduto} \nDrescricao: {p.DescricaoDoProduto}\n--- ");

            }
            else
            {
                Console.WriteLine("Pedido não encontrado");
            }
        }

        public void removerPedido(int id)
        {
            Pedido p = listaPedidos.Find(x => x.PedidoId == id);
            if(p != null)
            {
                listaPedidos.Remove(p);
                Console.WriteLine($"Pedido {id} removido...");
            }
            else
            {
                Console.WriteLine("Pedido não encontrado");
            }
            
        }

        public void todosPedidos()
        {
            foreach (var item in listaPedidos)
            {
                Console.Write($"\nID: {item.PedidoId} \nData: {item.DataEmissao} \nValor: {item.ValorDoProduto} \nDrescricao: {item.DescricaoDoProduto}\n--- ");
            }
        }

        public float calcularPrecoTotal()
        {
            float total = 0;

            foreach (var item in listaPedidos)
            {
                total += item.ValorDoProduto;
            }

            return total;
            
        }
        //Metodos que forem necessários
    }

    




}
