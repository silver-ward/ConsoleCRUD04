Este projeto é uma aplicação de console desenvolvida em C# com .NET, cujo objetivo é realizar operações básicas de CRUD (Create, Read, Update, Delete) para gerenciar clientes.

Funcionalidades
Ao iniciar a aplicação, o sistema exibe um menu com as seguintes opções:

objectivec
Copy
Edit
SISTEMA DE CONTROLE DE CLIENTES:

    (1) CADASTRAR
    (2) CONSULTAR
    (3) ATUALIZAR
    (4) EXCLUIR

INFORME A OPÇÃO DESEJADA:
Com base na opção escolhida pelo usuário, o programa executa uma das seguintes operações:

Cadastrar Cliente: Registra um novo cliente.

Consultar Clientes: Lista os clientes existentes.

Atualizar Cliente: Permite editar os dados de um cliente.

Excluir Cliente: Remove um cliente do sistema.

Após a execução, o usuário pode optar por continuar utilizando o sistema ou encerrar a aplicação.

Estrutura do Projeto
Program.cs: Contém o ponto de entrada da aplicação e o menu principal.

Controllers/ClienteController.cs: Contém os métodos responsáveis pelas ações de CRUD.

Obs: O código apresentado utiliza recursividade para reiniciar o menu sempre que o usuário deseja continuar.

Requisitos
.NET SDK 6.0 ou superior

Terminal/console para executar a aplicação

Como Executar
Clone o repositório:

bash
Copy
Edit
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
Execute o projeto:

bash
Copy
Edit
dotnet run
Siga as instruções no menu.
