using System;
using MaquinaVendas.interfaces;

namespace MaquinaVendas.services
{
    public class MaquinaVendasSimples : IMaquinaVenda, IDizerHora
    {
        private ICarregarMenu _menuService;

        public MaquinaVendasSimples(ICarregarMenu carregarMenu)
        {
            this._menuService = carregarMenu;
        }
        public void exibirMenu()
        {
            var produtos = _menuService.CarregarMenu();

            if (produtos != null)
            {
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.ToString());
                }
            }else
            {
                Console.WriteLine("Não foi possível carregar as informações de menu!");
            }
        }

        public void horaAtual()
        {
            Console.WriteLine("");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Data: {dateTime:d} às {dateTime:t}.");
        }
        


        public void Start()
        {
            
            exibirMenu();
            horaAtual();
           
        }

    }
}
