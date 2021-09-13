using System;
using System.Collections.Generic;

namespace ATV2
{
    class Program
    {
        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("Selecione uma Opção: ");
            Console.WriteLine("[1] - Inserir Pedido");
            Console.WriteLine("[2] - Buscar Pedido");
            Console.WriteLine("[3] - Remover Pedido");
            Console.WriteLine("[4] - Lista dos Pedidos");
            Console.WriteLine("[9] - Sair");
            Console.Write("Opção: ");
            int op = Convert.ToInt32(Console.ReadLine()); // Converto a entrada do usuario para int

            return op;
        }
        static void Main(string[] args)
        {
            Loja loja = new Loja();
            int id = 0;

            Pedido pedido = new Pedido(01, "02/09/2021", 90, "novo");
            loja.inserirPedido(pedido);
            pedido = new Pedido(02, "12/09/2021", 20, "usado");
            loja.inserirPedido(pedido);
            pedido = new Pedido(03, "14/09/2021", 60, "novo");
            loja.inserirPedido(pedido);

            int op = 0; // Valor da operação que o usuario ira realizar
            while (op != 9)
            {
                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1: //inserir pedido
                        Console.WriteLine("Inserir Pedido");
                        pedido = new Pedido();
                        Console.WriteLine("Id: ");
                        pedido.PedidoId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Data (d/m/a): ");
                        pedido.DataEmissao = Console.ReadLine();
                        Console.WriteLine("Valor: ");
                        pedido.ValorDoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Descrição: ");
                        pedido.DescricaoDoProduto = Console.ReadLine();

                        loja.inserirPedido(pedido);

                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey();//ao pressionar uma tecla o codigo continuara

                        break;

                    case 2: //busca pedido
                        Console.WriteLine("Buscar Pedido");
                        Console.WriteLine("Informe o ID do Pedido: ");
                        id = Convert.ToInt32(Console.ReadLine());// Converto a entrada do usuario para int
                        loja.buscarPedido(id);

                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey();//ao pressionar uma tecla o codigo continuara
                        break;

                    case 3: //remover pedido
                        Console.WriteLine("Remover Pedido");
                        Console.WriteLine("Informe o ID do Pedido: ");
                        id = Convert.ToInt32(Console.ReadLine());// Converto a entrada do usuario para int
                        loja.removerPedido(id);

                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey();//ao pressionar uma tecla o codigo continuara

                        break;

                    case 4: //lista pedido
                        Console.WriteLine("Listar Todos os jogos");
                        loja.todosPedidos();

                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey(); //ao pressionar uma tecla o codigo continuara
                        break;

                    case 5: //finalizar compra
                        Console.WriteLine("Finalizar Compra");
                        loja.calcularPrecoTotal();
                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey(); //ao pressionar uma tecla o codigo continuara
                        break;
                }
            }


            //loja.ListaPedidos.Add(new Pedido(01, "02/09/2021", 50, "novo"));
            //loja.ListaPedidos.Add(new Pedido(02, "02/09/2021", 70, "novo"));

            //loja.removerPedido(5);

            //Funcionario g = new Gerente();
            //Funcionario e = new Estagiario();

            //(g as Gerente).calcularDescontoMaior(0);

            //loja.buscarPedido();

            
           
        }
    }
}
