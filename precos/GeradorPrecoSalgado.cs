using System;
using MaquinaVendas.models;

namespace MaquinaVendas.precos
{
    public class GeradorPrecoSalgado : GeradorPreco
    {
        public override string GerarPrecoProduto(Produto produto)
        {
            var precoBase = base.GerarPrecoProduto(produto);
            return $"{precoBase} + {produto.Preco * 0.2m:0.##} Taxa de Consumo";
        }
    }
}
