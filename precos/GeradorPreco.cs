using System;
using MaquinaVendas.models;

namespace MaquinaVendas.precos
{
    public class GeradorPreco
    {
        public virtual string GerarPrecoProduto(Produto produto)
        {
            return $"{produto.Preco:0.##}";
        }
    }
}
