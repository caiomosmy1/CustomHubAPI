# CustomHubAPI
API Clientes, auditacao, filtros e paginacao. 


## Introdução do projeto
Uma API de gerenciamento de clientes, 
contatos e endereços (frequentemente 
chamada de API de CRM ou Cadastro de 
Clientes) serve para unificar as 
informações cadastrais do seu negócio, 
permitindo criar, ler, atualizar e 
excluir (CRUD) dados de clientes e 
suas respectivas localizações.

## Arquitetura Domain-Driven Design (DDD)

```mermaid
flowchart TD
    Cliente["[ Cliente HTTP ]"] -->|json| Presentation["[1. Presentation (Controller)]"]
    Presentation -->|Recebe CriarClienteDTO| Application["[2. Application (AppService)]"]
    Application -->|Orquestra a transação / Mapeia DTO| Domain["[3. Domain (Entidades / Business)]"]
    Domain -->|Retorna entidade validada| Infrastructure["[4. Infrastructure (Repository)]"]
    Infrastructure -->|EF Core gera o SQL| Postgres["[Banco PostgreSQL]"]

## instalação e configuração 


## Uso principal 
CRM para gerenciamento de contatos.


## Solucoes 
Esse projeto resolve, fundamentalmente, 
o problema de desorganização, inconsistência 
e falta de controle sobre os dados mais 
valiosos de uma empresa: os seus clientes.

Em sistemas legados ou mal estruturados, 
informações de contatos e endereços 
costumam ficar espalhadas, duplicadas 
ou expostas a falhas humanas. Ao unir 
DDD, EF Core, PostgreSQL e DTOs, você 
não está apenas criando um cadastro; 
essa API é uma espinha dorsal de dados
confiável.


## Referências


## 

