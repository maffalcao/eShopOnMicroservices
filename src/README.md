![microservices_remastered](https://user-images.githubusercontent.com/1147445/110304529-c5b70180-800c-11eb-832b-a2751b5bda76.png)

There is a couple of microservices which implemented **e-commerce** modules over **Catalog, Basket, Discount** and **Ordering** microservices with **NoSQL (MongoDB, Redis)** and **Relational databases (PostgreSQL, Sql Server)** with communicating over **RabbitMQ Event Driven Communication** and using **Ocelot API Gateway**.

## Whats Including In This Repository

We have implemented below **features over the run-aspnetcore-microservices repository**.

#### Catalog microservice which includes;

- ASP.NET Core Web API application
- REST API principles, CRUD operations
- **MongoDB database** connection and containerization
- Repository Pattern Implementation
- Swagger Open API implementation

#### Basket microservice which includes (under construction);

- ASP.NET Web API application
- REST API principles, CRUD operations
- **Redis database** connection and containerization
- Consume Discount **Grpc Service** for inter-service sync communication to calculate product final price
- Publish BasketCheckout Queue with using **MassTransit and RabbitMQ**

#### Discount microservice which includes (under construction);

- ASP.NET **Grpc Server** application
- Build a Highly Performant **inter-service gRPC Communication** with Basket Microservice
- Exposing Grpc Services with creating **Protobuf messages**
- Using **Dapper for micro-orm implementation** to simplify data access and ensure high performance
- **PostgreSQL database** connection and containerization

#### Microservices Communication (under construction)

- Sync inter-service **gRPC Communication**
- Async Microservices Communication with **RabbitMQ Message-Broker Service**
- Using **RabbitMQ Publish/Subscribe Topic** Exchange Model
- Using **MassTransit** for abstraction over RabbitMQ Message-Broker system
- Publishing BasketCheckout event queue from Basket microservices and Subscribing this event from Ordering microservices
- Create **RabbitMQ EventBus.Messages library** and add references Microservices

#### Ordering Microservice (under construction)

- Implementing **DDD, CQRS, and Clean Architecture** with using Best Practices
- Developing **CQRS with using MediatR, FluentValidation and AutoMapper packages**
- Consuming **RabbitMQ** BasketCheckout event queue with using **MassTransit-RabbitMQ** Configuration
- **SqlServer database** connection and containerization
- Using **Entity Framework Core ORM** and auto migrate to SqlServer when application startup

#### API Gateway Ocelot Microservice (under construction)

- Implement **API Gateways with Ocelot**
- Sample microservices/containers to reroute through the API Gateways
- Run multiple different **API Gateway/BFF** container types
- The Gateway aggregation pattern in Shopping.Aggregator

#### WebUI ShoppingApp Microservice (under construction)

- ASP.NET Core Web Application with Bootstrap 4 and Razor template
- Call **Ocelot APIs with HttpClientFactory** and **Polly**

#### Microservices Cross-Cutting Implementations (under construction)

- Implementing **Centralized Distributed Logging with Elastic Stack (ELK); Elasticsearch, Logstash, Kibana and SeriLog** for Microservices
- Use the **HealthChecks** feature in back-end ASP.NET microservices
- Using **Watchdog** in separate service that can watch health and load across services, and report health about the microservices by querying with the HealthChecks

#### Microservices Resilience Implementations (under construction)

- Making Microservices more **resilient Use IHttpClientFactory** to implement resilient HTTP requests
- Implement **Retry and Circuit Breaker patterns** with exponential backoff with IHttpClientFactory and **Polly policies**

#### Ancillary Containers (under construction)

- Use **Portainer** for Container lightweight management UI which allows you to easily manage your different Docker environments
- **pgAdmin PostgreSQL Tools** feature rich Open Source administration and development platform for PostgreSQL

#### Docker Compose establishment with all microservices on docker;

- Containerization of microservices
- Containerization of databases
- Override Environment variables

## Run The Project

You will need the following tools:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.Net 7](https://dotnet.microsoft.com/download/dotnet-core/5)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)