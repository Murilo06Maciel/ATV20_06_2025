# Task Manager Application

Este projeto é uma aplicação web simples para gerenciar tarefas, desenvolvida em ASP.NET 8.0. A aplicação permite que os usuários adicionem, editem, excluam e visualizem tarefas em um banco de dados.

## Estrutura do Projeto

A estrutura do projeto é a seguinte:

```
TaskManagerApp
├── Controllers
│   └── TasksController.cs       # Controlador para gerenciar operações CRUD de tarefas
├── Models
│   └── Task.cs                  # Modelo de dados para uma tarefa
├── Data
│   └── TaskContext.cs           # Contexto do banco de dados
├── Views
│   └── Tasks
│       ├── Create.cshtml        # View para criar uma nova tarefa
│       ├── Edit.cshtml          # View para editar uma tarefa existente
│       ├── Delete.cshtml        # View para confirmar a exclusão de uma tarefa
│       ├── Index.cshtml         # View que lista todas as tarefas
│       └── Details.cshtml       # View que exibe os detalhes de uma tarefa específica
├── wwwroot
│   └── css
│       └── site.css             # Estilos CSS para a aplicação
├── appsettings.json             # Configurações da aplicação
├── Program.cs                   # Ponto de entrada da aplicação
├── Startup.cs                   # Configuração dos serviços e pipeline de requisições
└── README.md                    # Documentação do projeto
```

## Funcionalidades

- **Adicionar Tarefas**: Permite que os usuários criem novas tarefas com título, descrição, data de vencimento e status de conclusão.
- **Editar Tarefas**: Os usuários podem editar tarefas existentes.
- **Excluir Tarefas**: Confirmação antes de excluir uma tarefa.
- **Listar Tarefas**: Exibe uma lista de todas as tarefas cadastradas.
- **Visualizar Detalhes**: Mostra informações detalhadas sobre uma tarefa específica.

## Instruções de Instalação

1. Clone o repositório:
   ```
   git clone <URL_DO_REPOSITORIO>
   ```
2. Navegue até o diretório do projeto:
   ```
   cd TaskManagerApp
   ```
3. Restaure as dependências:
   ```
   dotnet restore
   ```
4. Configure a string de conexão no arquivo `appsettings.json`.
5. Execute a aplicação:
   ```
   dotnet run
   ```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir um problema ou enviar um pull request.