namespace ATV2
{
    class Gerente : Funcionario
    {
        private string senha;

        public float calcularDescontoMaior(float valorProduto)
        {
            float desconto = valorProduto - (valorProduto * 25) / 100;
            return desconto;
        }
    }
}
