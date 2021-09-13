namespace ATV2
{
    class Estagiario : Funcionario
    {
        public float calcularDescontoMenor(float valorProduto)
        {
            float desconto = valorProduto - (valorProduto * 10) / 100;
            return desconto;
        }
    }
}
