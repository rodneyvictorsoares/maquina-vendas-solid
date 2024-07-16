using System;
using MaquinaVendas.models;
using MaquinaVendas.precos;

namespace MaquinaVendas.extensoes
{
    public static class ExtensoesTaxa
    {
        public static GeradorPreco ObterTaxaPreco(this Produto produto)
        {
            switch (produto.Tipo)
            {
                case "Refrigerante":
                    return new GeradorPrecoRefrigerante();
                case "Salgado":
                    return new GeradorPrecoSalgado();
                case "Biscoito":
                    return new GeradorPrecoBiscoito();
                default:
                    return new GeradorPreco();
            }
        }
    }
}
