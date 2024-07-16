using System;
using MaquinaVendas.models;

namespace MaquinaVendas.interfaces
{
    public interface ICarregarMenu
    {
        List<Produto> CarregarMenu();
    }
}
