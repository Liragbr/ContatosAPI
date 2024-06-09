## 📞 Contacts API

This is an API for contact management, built with ASP.NET Core using Entity Framework Core, connected to a database hosted on SQL Server 2022 Manager.

## API Routes

- `GET api/contacts`: Returns a list of all contacts.
- `GET api/contacts/{id}`: Returns a specific contact based on the provided ID.
- `POST api/contacts`: Adds a new contact.
- `PUT api/contacts`: Updates the information of an existing contact.
- `DELETE api/contacts/{id}`: Removes a contact based on the provided ID.

## Tools

- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore`

## Usage

Ensure that you have the .NET Core SDK installed. To run the API locally, execute the following commands in the terminal:
```
dotnet restore
```
```
dotnet run
```
