using System;
using MaquinaVendas.models;

namespace MaquinaVendas.precos
{
    public class GeradorPrecoBiscoito : GeradorPreco
    {
         public override string GerarPrecoProduto(Produto produto)
        {
            var precoBase = base.GerarPrecoProduto(produto);
            return $"{precoBase} + {produto.Preco * 0.05m:0.##} Taxa de Consumo";
        }
    }
}
