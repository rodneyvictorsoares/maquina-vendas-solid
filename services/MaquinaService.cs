using System;
using System.Text.Json;
using MaquinaVendas.interfaces;
using MaquinaVendas.models;

namespace MaquinaVendas.services
{
    public class MaquinaService : IComprimentar, IDizerHora, IMaquinaVenda
    {
        private ICarregarMenu _menuService;
        public MaquinaService(ICarregarMenu carregarMenu)
        {
            this._menuService = carregarMenu;
        }

        public void digaOla()
        {
            Console.Write("Informe o seu nome: ");
            var usuario = Console.ReadLine();
            Console.WriteLine($"Bem vindo {usuario}, segue abaixo o nosso cardapio:");
            Console.WriteLine("");
        }

        public void digaAdeus()
        {
            Console.Write("Pessione qualquer tecla para encerrar...");
            Console.ReadKey(true);
        }

        public void horaAtual()
        {
            Console.WriteLine("");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Data: {dateTime:d} às {dateTime:t}.");
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

        public void Start()
        {
            digaOla();
            exibirMenu();
            horaAtual();
            digaAdeus();
        }
    }
}
