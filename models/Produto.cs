using System;
using MaquinaVendas.extensoes;
using MaquinaVendas.precos;

namespace MaquinaVendas.models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public string Tipo { get; set; } = "";

        public override string ToString()
        {
            return $"ID: {ID} - {Nome}              - R$ {this.ObterTaxaPreco().GerarPrecoProduto(this)}";
        }
    }
}
