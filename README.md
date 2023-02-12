What is the Transferencia?
=====================
The Transferencia is a open-source project written in .NET Core

The goal of this project is implement the most common used technologies and share with the technical community the best way to develop great applications with .NET

Comandos dotnet para criar o projeto:

Seguir a documentação: https://www.macoratti.net/19/10/net_climp1.htm

## Give a Star! :star:
If you liked the project or if contas helped you, please give a star ;)

## How to use:
- You will need the latest Visual Studio 2022 and the latest .NET Core SDK.
- ***Please check if you have installed the same runtime version (SDK) described in global.json***
- The latest SDK and tools can be downloaded from https://dot.net/core.

Also you can run the Contas in Visual Studio Code (Windows, Linux or MacOS).

To know more about how to setup your enviroment visit the [Microsoft .NET Download Guide](https://www.microsoft.com/net/download)

## Technologies implemented:

- ASP.NET 6.0
 - ASP.NET MVC Core
 - ASP.NET WebApi Core with JWT Bearer Authentication
 - ASP.NET Identity Core
- Entity Framework Core 6.0
- .NET Core Native DI
- AutoMapper
- FluentValidator
- Swagger UI with JWT support

## Architecture:

- Full architecture with responsibility separation concerns, SOLID and Clean Code
- Domain Driven Design (Layers and Domain Model Pattern)
- Domain Events
- Domain Notification
- Domain Validations
- CQRS (Imediate Consistency)
- Event Sourcing
- Unit of Work
- Repository

## Fluxo
<h1 align="center">
  <img src="https://github.com/MateusMaceedo/Impulsionatech-Gerenciador-Contas/blob/feature/MigracaoDotnet6/img/Fluxo%20contas%20bancarias.drawio.png?raw=true">
</h1>

## News

**v1.0 - 30/12/2022**
- Migrated for .NET 6.0
- All dependencies is up to date

## Disclaimer:
- **NOT** intended to be a definitive solution
- Beware to use in production way
- Maybe you don't need a lot of implementations that is included, try avoid the **over engineering**

## Pull-Requests
Make a contact! Don't submit PRs for extra features, all the new features are planned

## We are Online:
See the project running on <a href="http://equinoxproject.azurewebsites.net" target="_blank">Azure</a>

### Operações no Mongo através do Docker
- Baixar a imagem: docker pull mongo
- Executar o container: docker run -d -p 27017-27017 --name transferencia-mongo mongo
- Entrar dentro do container: docker exec -it transferencia-mongo /bin/bash
- Entrar dentro do mongo: mongosh
- Comandos mongo
  1. show dbs ou show databases - lista os bancos
  2. use TransferenciasDb - cria um novo banco de dados
  3. db.createCollection('Enderecos') - Cria uma coleção
  4. db.Enderecos.insert({"id": "123", "dataTransferencia": "2023-02-12T21:40:57.912Z", "alteradoEm": "2023-02-12T21:40:57.912Z", "cep": "08589350", "logradouro": "Rua Agata", "unidadeFederacao": "SSP", "numeroLogradouro": 125, "bairro": "Jardim Nicea", "isValid": true, "isFreteGratis": true
  }) - insere registros
  5. db.Enderecos.find({}).pretty() - lista os registros
  6. show collections - listas as coleções
  7. db.Enderecos.remove({}) - remove as coleções

### Docker no Vs Code
https://conexaopanvel.faccat.br/criando-um-container-docker-com-visual-studio-code/#:~:text=Agora%20utilize%20o%20atalho%20%E2%80%9Cctrl,apenas%20configurar%20para%20seu%20reposit%C3%B3rio.


## 👨🏻‍🚀 Sobre mim
<a href="https://www.linkedin.com/in/mateus-macedo-937a32163/">
 <img style="border-radius:50%" width="100px; "src="https://avatars.githubusercontent.com/u/63172367?s=460&u=11fd26ea8a7f5663d7707d7ef254e4f8bfca1b05&v=4"/>
 <p>Mateus Macedo</p>
</a>
