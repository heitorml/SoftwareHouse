# SoftwareHouse (Em desenvolvimento)

O projeto tem como objetivo disponibilizar gerenciar a prospecção de projetos de uma SoftwareHouse onde os clientes podem solicitar orçamentos para diversos tipos de projetos.
O orçamento é calculado através da analise tipo, quantidade de recursos, etc..


---

### Sobre a mensageria 

Os eventos são transmitos através do messageBroker RabbitMq, a implementação utiliza o MasstransitV8 (https://masstransit.io/quick-starts).
- **MassTransitV8**: biblioteca de mensageria para comunicação entre microsserviços
- **RabbitMQ**: broker de mensagens usado como transporte

---
### Sobre a aborgem arquitetural

Para esta solução foi escolhida a Clean Architecture que traz os benefícios

- Separação de responsabilidades em 4 camadas principais
- Independência da infraestrutura
- Inversão de dependência via interfaces
- Facilidade para testes unitários e mocks

---

## 🛠️ Tecnologias e Padrões Utilizados

### 🧼 Clean Architecture
- Separação de responsabilidades em 4 camadas principais
- Independência da infraestrutura
- Inversão de dependência via interfaces
- Facilidade para testes unitários e mocks

### 🟣 .NET 8
- Última versão LTS da plataforma .NET
- Alto desempenho e suporte a APIs modernas

### 🌐 ASP.NET Core
- Framework para construção de APIs RESTful robustas
- Usado nos projetos `Orders.Api` e `Resales.Api`

### 🔁 Worker Service
- Utilizado para processamentos em background com o `Orders.Worker`
- Ideal para filas, cron jobs ou mensageria

### 🧼 Resilience 
- Polly - Biblioteca de politicas de resiliencia em chamadas Http
- Politicas de retentativas exponencial
- Circuit Breaker
- Timeout

### 📦 Refit 
- Para comunicação entre a `Orders.Api` e `Resales.Api`
- Abstrai toda a implementação do HttpClient 

### ✔️ Fail Fast Validation 
- Utiliza a biblioteca FluentValidation para efetuar validações de requisições

### 🗂️ Repositorio NoSQL 
- Utilização do MongoDb para armazenamento não relacional dos documentos  

### 📦 MassTransit + RabbitMQ
- **MassTransit**: biblioteca de mensageria para comunicação entre microsserviços
- **RabbitMQ**: broker de mensagens usado como transporte

### 🧪 xUnit + Moq
- **xUnit**: framework de testes unitários
- **Moq**: criação de mocks de dependências para testes
