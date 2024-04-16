## 📞 API de Contatos

Esta é uma API para gerenciamento de contatos, construída com ASP.NET Core utilizando o Entity Framework Core, com interligação com o banco de dados hospedado no SQL Server 2022 Manager.

## Rotas da API

- `GET api/contatos`: Retorna uma lista de todos os contatos.
- `GET api/contatos/{id}`: Retorna um contato específico com base no ID fornecido.
- `POST api/contatos`: Adiciona um novo contato.
- `PUT api/contatos`: Atualiza as informações de um contato existente.
- `DELETE api/contatos/{id}`: Remove um contato com base no ID fornecido.
## Ferramentas

- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore`
## Utilização

Certifique-se de ter o .NET Core SDK instalado. Para rodar a API localmente, execute os seguintes comandos no terminal:
```
dotnet restore
```
```
dotnet run
```
