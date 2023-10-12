# The big picture:

![microservices_remastered](https://user-images.githubusercontent.com/1147445/110304529-c5b70180-800c-11eb-832b-a2751b5bda76.png)

This repository contains several microservices designed to provide various e-commerce functionalities. The microservices include Catalog, Basket, Discount, and Ordering, and they utilize a combination of NoSQL databases such as MongoDB and Redis, as well as relational databases like PostgreSQL and SQL Server. Communication between these microservices is achieved through RabbitMQ's Event-Driven Communication, and they are all managed by the Ocelot API Gateway.

## What's Covered in This Repository

We have implemented the following features within the run-aspnetcore-microservices repository:

#### Catalog Microservice 

- An ASP.NET Core Web API application
- Follows REST API principles for CRUD operations
- Connects to a MongoDB database and is containerized
- Implements the Repository Pattern
- Includes Swagger Open API documentation

#### Basket Microservice

- An ASP.NET Web API application
- Adheres to REST API principles for CRUD operations
- Connects to a Redis database, which is containerized
- Utilizes a gRPC service (Discount) for inter-service synchronization to calculate the final product price
- Publishes messages to the BasketCheckout Queue using MassTransit and RabbitMQ

#### Discount Microservice 

- An ASP.NET gRPC Server application
- Implements highly performant inter-service gRPC communication with the Basket Microservice
- Exposes gRPC Services by creating Protobuf messages
- Utilizes Dapper for micro-ORM implementation to ensure high performance
- Connects to a PostgreSQL database, which is containerized

#### Microservices Communication (under development)

- Synchronous inter-service gRPC Communication
- Asynchronous Microservices Communication using the RabbitMQ Message-Broker Service
- Utilizes the RabbitMQ Publish/Subscribe Topic Exchange Model
- Abstraction over RabbitMQ using MassTransit
- Publishes BasketCheckout event queues from the Basket microservices and subscribes to these events from the Ordering microservices
- Includes the RabbitMQ EventBus.Messages library with references to other microservices

#### Ordering Microservice (work in progress)

- Implements DDD (Domain-Driven Design), CQRS (Command Query Responsibility Segregation), and Clean Architecture following best practices
- Develops CQRS using MediatR, FluentValidation, and AutoMapper packages
- Consumes BasketCheckout event queues from RabbitMQ using MassTransit-RabbitMQ Configuration
- Connects to a SQL Server database, which is containerized
- Utilizes Entity Framework Core ORM and performs automatic migrations to SQL Server on application startup

#### API Gateway Ocelot Microservice (soon)

- Implements API Gateways using Ocelot
- Provides sample microservices/containers to reroute through the API Gateways
- Supports multiple types of API Gateway/BFF containers
- Follows the Gateway aggregation pattern in Shopping.Aggregator

#### WebUI ShoppingApp Microservice (soon)

- An ASP.NET Core Web Application with Bootstrap 4 and Razor templates
- Makes calls to Ocelot APIs using HttpClientFactory and Polly

#### Microservices Cross-Cutting Implementations (soon)

- Implements Centralized Distributed Logging with the Elastic Stack (ELK) comprising Elasticsearch, Logstash, Kibana, and SeriLog for Microservices
- Utilizes the HealthChecks feature in the back-end ASP.NET microservices
- Includes a Watchdog service that monitors the health and load across services, reporting health status through HealthChecks

#### Microservices Resilience Implementations (soon)

- Enhances microservices' resilience by using IHttpClientFactory for resilient HTTP requests
- Implements Retry and Circuit Breaker patterns with exponential backoff using IHttpClientFactory and Polly policies

#### Ancillary Containers 

- Utilizes Portainer for lightweight container management with a user-friendly interface for managing different Docker environments
- Features pgAdmin PostgreSQL Tools, a rich open-source administration and development platform for PostgreSQL

#### Docker Compose Setup with all Microservices in Docker (under development)

- Containerizes all microservices and databases
- Allows for overriding environment variables

## Running the Project

To run this project, you will need the following tools:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET 7](https://dotnet.microsoft.com/download/dotnet-core/5)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)