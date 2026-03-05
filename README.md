# Desafio Técnico - ZCK Software

Olá, Isabela! Bem-vinda ao seu desafio técnico.
O objetivo deste teste é avaliar sua capacidade de pesquisa, adaptação a novas tecnologias, organização de código e documentação utilizando Git.

## Desafio 1: Cadastro de Insumos (Desenvolvimento do Zero)

No nosso ecossistema, o gerenciamento de matérias-primas é fundamental para a criação das Ordens de Produção. Sua tarefa é criar um CRUD (Create, Read, Update, Delete) simples para um "Cadastro de Insumos".

### Requisitos Técnicos
* **Back-end (.NET 8):** Crie uma API RESTful com endpoints para Criar, Listar e Excluir um insumo. 
  * *Campos obrigatórios do Insumo:* `Id`, `Nome`, `UnidadeMedida` (ex: Kg, Litro) e `Custo`.
* **Banco de Dados (SQL Server):** A API deve persistir os dados no SQL Server. Você pode fornecer o script SQL de criação da tabela ou utilizar o Entity Framework Core com Migrations.
* **Front-end (Angular):** Crie uma interface simples (SPA) com um formulário para cadastrar o insumo e uma tabela/lista para exibir os insumos cadastrados, consumindo a sua API.

### Critérios de Entrega
1. Faça os commits diretamente neste repositório.
2. Suas mensagens de commit devem ser claras e descritivas (ex: `feat: adiciona endpoint de criacao de insumos`).
3. Crie um arquivo com nome `Manual.md`, contendo um passo a passo simples de como rodar a sua aplicação (comandos do Angular, configuração da connection string do banco, etc.).

**Prazo de Entrega:** Até a próxima quinta-feira **(12/03/2026)**.
Bom trabalho!