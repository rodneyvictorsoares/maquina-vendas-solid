using System;
using MaquinaVendas.models;

namespace MaquinaVendas.precos
{
    public class GeradorPrecoRefrigerante : GeradorPreco
    {
        public override string GerarPrecoProduto(Produto produto)
        {
            var precoBase = base.GerarPrecoProduto(produto);
            return $"{precoBase} + {produto.Preco * 0.1m:0.##} Taxa de Armazenamento";
        }
    }
}
