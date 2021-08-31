using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2
{
    class Pedido
    {
        private int PedidoID { get; set; }
        private Date dataEmissao { get; set; }
        private float valorDoProduto { get; set; }
        private string descricaoDoProduto { get; set; }

        public Pedido(int pedidoID, Date dataEmissao, float valorDoProduto, string descricaoDoProduto)
        {
            PedidoID = pedidoID;
            this.dataEmissao = dataEmissao;
            this.valorDoProduto = valorDoProduto;
            this.descricaoDoProduto = descricaoDoProduto;
        }

        public float calcularPrecoTotal()
        {
           
        }    
    }
}
