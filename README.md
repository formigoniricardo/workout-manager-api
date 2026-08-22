Markdown
# Workout Manager API 

Uma API RESTful desenvolvida em C# e .NET para gestão de treinos e rotinas de exercícios. Este projeto foi construído para demonstrar a estruturação de uma aplicação back-end moderna, focada em boas práticas de mapeamento objeto-relacional e arquitetura de controladores.

##  Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** ASP.NET Core Web API (.NET 8/9)
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQLite (leve e embutido, ideal para testes rápidos)
* **Documentação:** Swagger / OpenAPI

## Funcionalidades (CRUD Completo)

A API fornece endpoints para o gerenciamento de rotinas de treino, permitindo:
* `POST /api/workouts` - Registrar um novo treino (título, grupo muscular, quantidade de séries).
* `GET /api/workouts` - Listar todos os treinos cadastrados.
* `GET /api/workouts/{id}` - Buscar os detalhes de um treino específico pelo ID.
* `PUT /api/workouts/{id}` - Atualizar informações de um treino existente.
* `DELETE /api/workouts/{id}` - Remover um treino do histórico.

## 🛠️ Como rodar o projeto localmente

Siga os passos abaixo para executar a API na sua máquina:

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/formigoniricardo/workout-manager-api.git](https://github.com/formigoniricardo/workout-manager-api.git)
Navegue até a pasta do projeto:

Bash
cd workout-manager-api/WorkoutManager.API
Atualize o Banco de Dados (Migrations):

Bash
dotnet ef database update
Execute a aplicação:

Bash
dotnet run
Acesse o Swagger:
Abra o navegador e acesse a URL gerada no terminal (geralmente http://localhost:5000/swagger ou https://localhost:5001/swagger) para testar os endpoints visualmente.

 
Desenvolvido por Ricardo Formigoni Souza

