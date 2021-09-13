namespace ATV2
{
    class Pedido
    {
        private int pedidoId { get; set; }
        public int PedidoId
        {
            get
            {
                return pedidoId;
            }
            set => pedidoId = value;

        }
        private string dataEmissao { get; set; }
        public string DataEmissao
        {
            get
            {
                return dataEmissao;
            }
            set => dataEmissao = value;
        }
        private float valorDoProduto { get; set; }
        public float ValorDoProduto
        {
            get
            {
                return valorDoProduto;
            }
            set => valorDoProduto = value;
        }
        private string descricaoDoProduto { get; set; }
        public string DescricaoDoProduto
        {
            get
            {
                return descricaoDoProduto;
            }
            set => descricaoDoProduto = value;
        }

        public Pedido()
        {

        }
        public Pedido(int pedidoID, string dataEmissao, float valorDoProduto, string descricaoDoProduto)
        {
            this.pedidoId = pedidoID;
            this.dataEmissao = dataEmissao;
            this.valorDoProduto = valorDoProduto;
            this.descricaoDoProduto = descricaoDoProduto;
        }


    }
}
