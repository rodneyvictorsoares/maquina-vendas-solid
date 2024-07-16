using MaquinaVendas.services;

namespace MaquinaVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            var CarregarMenu = new CarregarMenuService();
            //MaquinaVendasSimples maquinaService = new MaquinaVendasSimples(CarregarMenu);
            MaquinaService maquinaService = new MaquinaService(CarregarMenu);
            maquinaService.Start();
        }
    }
}