using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2
{
    class Gerente : Funcionario
    {
        private string senha;

        public float calcularDescontoMaior(float valorProduto)
        {
            float desconto = (valorProduto * 25) / 100 - valorProduto;
            return desconto;
        }
    }
}
