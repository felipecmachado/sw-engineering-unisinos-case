# sw-engineering-unisinos-case 
### El Universidad
An comprehensive (not yet) university management web application. 

------------
#### About

This is a project created with the **solely purpose of applying several topics** that were presented **during the [Software Engineering graduate program](https://www.unisinos.br/pos/especializacao/engenharia-de-software/hibrido/porto-alegre).**

#### Features

- [x] Feat 1
- [x] Feat 2
- [ ] Feat 3

#### Architecture Decision Records

#### C4 Model

#### OpenAPI Specification

#### Technologies and patterns used

- [x] [NET 6](https://docs.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-6)
- [x] Rich domain model using DDD (Domain Driven Design)
- [x] CQRS (Command Query Responsibility Segregation pattern)
- [x] ASP.NET WebAPI
- [x] Background workers using [cron expressions](https://github.com/HangfireIO/Cronos)
- [x] EntityFrameworkCore as ORM
- [x] UnitOfWork pattern using [EntityFrameworkCore.DataAccess library](https://github.com/ffernandolima/ef-core-data-access/tree/ef-core-6)
- [x] [MediatR](https://github.com/jbogard/MediatR)
- [x] AutoMapper as object-object mapper
- [x] MySql
- [x] Docker (including docker-compose)
- [ ] Strongly-typed validation rules using FluentValidation
- [ ] Redis as Cache provider
- [ ] Messaging using Apache Kafka
- [ ] API Gateway
- [ ] Unit tests using AAA pattern ([Arrange, Act, Assert](https://docs.microsoft.com/pt-br/visualstudio/test/unit-test-basics?view=vs-2022)): 

### Getting started

First you will need NET 6 SDK. Then clone this repository and enter the /src directory

Make sure you have installed and configured docker in your environment. 
After that, you can run the below commands from the /src/ directory and get started with immediately.

```powershell
docker-compose build
docker-compose up
```

Enter the BackgroundServices directory and start the project by running dotnet run 
```powershell
cd ElUniversidad.BackgroundServices
dotnet build
dotnet run
```
Now enter the API directory and start the project by running dotnet run  
```powershell
cd ..\ElUniversidad.API
dotnet build
dotnet run
```
Navigate to the https://localhost:7227/swagger or http://localhost:5227  
It is suggested to wait a few minutes, so real data can be collected.

### Read further

### References:
    
    Kudos to the following contributors:

License This project is licensed under the MIT license. Copyright (c) 2022 Felipe C Machado.
