# 🧩 EcomLab - Infoeste 2025

Este repositório contém a aplicação desenvolvida e apresentada durante o **curso ministrado na [Infoeste 2025](https://www.unoeste.br/site/controleeventos/VerAtividade.aspx?eve_codigo=1755&atv_codigo=9552)**.  
O projeto demonstra a integração entre **microserviços .NET**, **mensageria** e **Elasticsearch**, para construção de uma solução moderna de **catálogo de produtos com busca inteligente**.

---

## 🏗️ Estrutura do Projeto

https://miro.com/welcomeonboard/Q3VBdmQybWxSbEJzK2Q2Y1NwNTE3T0hDN2ZzUHArYU1oUmE4RFVLbmlyZXNGQ2RVMllZY1VIc1BVamVLckw4UUdpZWQwcHhsYVpvS2JoYkZWaVkzdmlTZkRnZUhOM3UyVFFUUXhFc1h4Z1ovb0QzRDBKV1dkYzBkVm0yRkEvUnVzVXVvMm53MW9OWFg5bkJoVXZxdFhRPT0hdjE=?share_link_id=688778382154

O repositório contém **dois projetos em .NET**:

### 1️⃣ api-ecomlab
**Função:** Serviço responsável pelo **gerenciamento de produtos, categorias e marcas** (CRUD) e pela **publicação de eventos** relacionados a produtos.

- Atua como **Producer** de mensagens para os tópicos:
  - `api-search.product-create`
  - `api-search.product-update`
- Esses tópicos são consumidos pela `api-search`.
- Cada evento publicado representa a criação ou atualização de um produto no sistema.

**Principais responsabilidades:**
- Cadastro e atualização de produtos.
- Emissão de eventos para sincronização com o mecanismo de busca (Elasticsearch).
- Exposição de endpoints RESTful.

---

### 2️⃣ api-search
**Função:** Serviço responsável por **indexar** e **consultar produtos** no **Elasticsearch**.

- Atua como **Consumer** dos tópicos:
  - `api-search.product-create`
  - `api-search.product-update`
- Ao consumir esses eventos, cria ou atualiza o **índice de produtos** no Elasticsearch.

**Principais funcionalidades:**
- Atualização automática do índice de produtos com base nos eventos recebidos.
- Endpoint público para consulta de produtos com **paginação**.
- Suporte a busca **tolerante a erros de digitação (fuzzy search)**.

---

## ⚙️ Tecnologias Utilizadas

- .NET 9  
- MySQL 8  
- Elasticsearch- 
- Entity Framework Core  
- Kafka
- Redis
- Docker  

---

## 🚀 Fluxo

![Fluxo da aplicação](https://raw.githubusercontent.com/IrineuAlmeidaJr/Infoeste2025/main/fluxo.png)



## ⚙️ Configuração da Aplicação (`appsettings.json`)

O arquivo `appsettings.json` contém todas as **configurações necessárias** para que a API-EcomLab funcione corretamente, incluindo **bancos de dados**, **cache** e **mensageria**.

```json
{
    "ConnectionStrings": {
        "MySql": "Server=127.0.0.1;Port=3306;Database=ecom-lab;User Id=root;Password=;",
        "Redis": "localhost:6380"
    },
    "Kafka": {
        "BootstrapServers": "localhost:29092",
        "GroupId": "api-search",
        "Topics": {
            "CreateProduct": "api-search.product-create",
            "UpdateProduct": "api-search.product-update"
        }
    },
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*"
}
