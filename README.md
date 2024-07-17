# 🏪 MaquinaVendas

![SOLID](https://img.shields.io/badge/SOLID-Principles-green)
![C#](https://img.shields.io/badge/C%23-8.0-blue)
![.NET 6.0](https://img.shields.io/badge/.NET-6.0-purple)

## 📖 Sobre o Projeto

MaquinaVendas é uma aplicação console desenvolvida em C# utilizando o .NET 6.0, que simula o funcionamento de uma máquina de vendas. O projeto é estruturado de forma orientada a serviços e usando os conceitos de SOLID, permitindo a fácil manutenção e extensão das funcionalidades.

## 🚀 Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET 6.0
- **IDE Recomendada**: Visual Studio 2022
- **SOLID**: Principios de boas práticas e arquitetura.

## 📂 Estrutura do Projeto

```plaintext
MaquinaVendas/
├── .vs/
├── bin/
├── data/
├── extensoes/
├── interfaces/
│   ├── ICarregarMenuService.cs
│   ├── IMaquinaVendasService.cs
│   └── ...
├── models/
│   ├── Produto.cs
│   ├── Venda.cs
│   └── ...
├── obj/
├── precos/
├── services/
│   ├── CarregarMenuService.cs
│   ├── MaquinaVendasSimples.cs
│   └── ...
├── MaquinaVendas.csproj
├── MaquinaVendas.sln
└── Program.cs
```

## Instalação e Execução

### Pré-requisitos
- .NET 6.0 SDK instalado
- Visual Studio 2022 ou Visual Studio Code

### Passos para Clonar e Executar
1. Clone o repositório:
    ```
    git clone https://github.com/seu-usuario/MaquinaVendas.git
    ```
2. Navegue até o diretório do projeto:
    ```
    cd MaquinaVendas
    ```
3. Restaure as dependências do projeto:
    ```
    dotnet restore
    ```
4. Compile o projeto:
    ```
    dotnet build
    ```
5. Execute a aplicação:
    ```
    dotnet run
    ```

## Uso

### Carregar Menu
O serviço `CarregarMenuService` é responsável por carregar o menu de produtos disponíveis na máquina de vendas, o mesmo é disponibilizado através de um arquivo **CSV** ou **JSON**.

## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias e correções.

## 📄 Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👥 Contribuidores

- Rodney Victor (https://github.com/rodneyvictorsoares) - Desenvolvedor

## 📞 Contato

Para dúvidas ou sugestões, entre em contato através do email: ordabelem@hotmail.com

---

Feito por Rodney Victor (https://github.com/rodneyvictorsoares)
