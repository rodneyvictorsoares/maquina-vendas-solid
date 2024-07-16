using System;
using MaquinaVendas.interfaces;
using MaquinaVendas.models;

namespace MaquinaVendas.services
{
    public class CarregarMenuCSVService : ICarregarMenu
    {
        public List<Produto> CarregarMenu()
        {
            var list = new List<Produto>();

            using (var reader = new StreamReader(@"./menu/menu.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    if (linha != null)
                    {
                        var valores = linha.Split(";");
                        list.Add(new Produto {
                            ID = int.Parse(valores[0]),
                            Nome = valores[1],
                            Preco = decimal.Parse(valores[2]),
                            Tipo = valores[3]
                        });
                    }
                    
                }
            }
            return list;
        }
    }
}
