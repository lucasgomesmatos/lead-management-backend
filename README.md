# Lead Management - Frontend
Sistema de gerenciamento de leads para empresas.

## Tech Stack
- [.NET 8](https://dotnet.microsoft.com/pt-br/?icid=SSM_AS_.NET)
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-2019)

---

Como executar o projeto:
```bash
# Clone o repositório

$ git clone  https://github.com/lucasgomesmatos/lead-management-backend.git

# Acesse a pasta do src/LeadManagement.Api/appsettings.json e configure a string de conexão com o banco de dados
```
```json
 "ConnectionStrings": {
    "DefaultConnection": "Server=;Database=;User Id=;Password=; Trusted_Connection=True; Encrypt=True; TrustServerCertificate=True;"
  },
```
```bash

# Rodo as migrations para criar o banco de dados 
# Acesse a pasta do src e execute o comando

$ dotnet ef database update --project LeadManagement.Infrastructure

# Execute o projeto

$ dotnet run --project LeadManagement.Api
```

Para acessar a documentação da API, acesse a rota: [https://localhost:5021/swagger/index.html](https://localhost:5021/swagger/index.html)

Verifique se a porta está correta, caso não esteja, verifique a porta que está sendo utilizada no seu ambiente.
