using System;
using System.Text.Json;
using MaquinaVendas.interfaces;
using MaquinaVendas.models;

namespace MaquinaVendas.services
{
    public class CarregarMenuService : ICarregarMenu
    {
        public List<Produto> CarregarMenu()
        {
            string menu = File.ReadAllText(@"./data/menu.json");
            var ret = JsonSerializer.Deserialize<List<Produto>>(menu);
            if (ret != null)
            {
                return ret;    
            }else
            {
                List<Produto> ret2 = new List<Produto>();
                ret2.Add(new Produto{ID=0,Nome="",Preco=0.0m,Tipo=""});
                return ret2;
            }
            
        }
    }
}
