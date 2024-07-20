README
MVC Gerenciador de Tarefas
MVC Gerenciador de Tarefas é um aplicativo web desenvolvido com ASP.NET Core MVC para gerenciar tarefas diárias. Ele permite aos usuários criar, visualizar, editar e excluir tarefas, além de buscar tarefas por título, data ou status.

Funcionalidades
Adicionar Nova Tarefa
Listar Tarefas
Visualizar Detalhes da Tarefa
Editar Tarefa
Excluir Tarefa
Buscar Tarefas
Tecnologias Utilizadas
ASP.NET Core MVC
Entity Framework Core
SQL Server
Bootstrap
Font Awesome
Pré-requisitos
.NET 6.0 SDK ou superior
SQL Server


Estrutura do Projeto
Models: Contém as classes de modelo, incluindo Tarefa e EnumStatusTarefa.
Controllers: Contém os controladores, incluindo TarefaController, que gerencia as operações CRUD para as tarefas.
Views: Contém as views Razor para exibir e interagir com as tarefas.
Tarefa
Index.cshtml: Lista todas as tarefas.
Details.cshtml: Exibe os detalhes de uma tarefa específica.
Create.cshtml: Formulário para adicionar uma nova tarefa.
Edit.cshtml: Formulário para editar uma tarefa existente.
Delete.cshtml: Confirmação para excluir uma tarefa.
