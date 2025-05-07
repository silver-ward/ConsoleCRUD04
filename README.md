# Sistema de Controle de Clientes (.NET Console App)

Este projeto é uma aplicação de console desenvolvida em C# com .NET, cujo objetivo é realizar operações básicas de CRUD (Create, Read, Update, Delete) para gerenciar clientes.

## Funcionalidades

Ao iniciar a aplicação, o sistema exibe um menu com as seguintes opções:

```
SISTEMA DE CONTROLE DE CLIENTES:

    (1) CADASTRAR
    (2) CONSULTAR
    (3) ATUALIZAR
    (4) EXCLUIR

INFORME A OPÇÃO DESEJADA:
```

Com base na opção escolhida pelo usuário, o programa executa uma das seguintes operações:

* **Cadastrar Cliente**: Registra um novo cliente.
* **Consultar Clientes**: Lista os clientes existentes.
* **Atualizar Cliente**: Permite editar os dados de um cliente.
* **Excluir Cliente**: Remove um cliente do sistema.

Após a execução, o usuário pode optar por continuar utilizando o sistema ou encerrar a aplicação.

## Estrutura do Projeto

* **Program.cs**: Contém o ponto de entrada da aplicação, exibe o menu principal e direciona as opções do usuário.
* **Controllers/ClienteController.cs**: Camada responsável por orquestrar a lógica da aplicação. Chama os métodos do repositório para realizar as operações de CRUD.
* **Entities/Cliente.cs**: Representa a entidade de domínio Cliente, contendo propriedades como nome, email, etc.
* **Interfaces/IClienteRepository.cs**: Define o contrato (interface) que a camada de repositório deve seguir. Garante desacoplamento entre a lógica de negócio e a persistência de dados.
* **Repositories/ClienteRepository.cs**: Implementa a interface IClienteRepository e contém a lógica para manipulação de dados.

## Requisitos

* [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/en-us/download)
* Terminal/console para executar a aplicação

## Como Executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. Execute o projeto:

   ```bash
   dotnet run
   ```

3. Siga as instruções no menu.
