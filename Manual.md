# 📦 Manual de Execução - Cadastro de Insumos

Este documento descreve os passos necessários para executar a aplicação de Cadastro de Insumos, composta por **backend (.NET 8)** e **frontend (Angular)**.

---

## 🛠️ Tecnologias Utilizadas

- .NET 8 (API REST)
- Entity Framework Core
- SQL Server
- Angular
- Swagger (documentação da API)

---

## 🚀 Backend (.NET 8)

### 📁 1. Acesse a pasta do projeto

```bash
cd ZCK.OrdensProducao.Api
```

---

### ⚙️ 2. Configure a connection string

Edite o arquivo:

```
appsettings.json
```

Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=SEU_BANCO;Trusted_Connection=True;"
}
```

---

### ▶️ 3. Execute a aplicação

```bash
dotnet run
```

---

### 🌐 4. Acesse a API

A documentação interativa estará disponível em:

```
http://localhost:5188/swagger
```

---

## 💻 Frontend (Angular)

### 📁 1. Acesse a pasta do projeto

```bash
cd insumos-front
```

---

### 📦 2. Instale as dependências

```bash
npm install
```

---

### ▶️ 3. Execute a aplicação

```bash
ng serve
```

---

### 🌐 4. Acesse no navegador

```
http://localhost:4200
```

---

## 📋 Funcionalidades

- ✅ Cadastro de insumos  
- ✅ Listagem de insumos  
- ✅ Exclusão de insumos  

---

## 🧠 Estrutura da Solução

- **Backend:** API REST responsável pelo gerenciamento dos dados e persistência no banco SQL Server  
- **Frontend:** Interface SPA em Angular consumindo a API  

---

## 📝 Observações

- Projeto desenvolvido seguindo padrão REST  
- Integração completa entre frontend e backend  
- Versionamento com Git utilizando commits semânticos  
- Documentação da API disponível via Swagger  

Projeto finalizado para entrega do desafio técnico.