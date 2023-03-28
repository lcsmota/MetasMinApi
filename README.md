# MetasMinApi

## 🌐 Status
<p>Finished project ✅</p>

#
## 🧰 Prerequisites

- .NET 6.0 or +

#
## 🔧 Installation

`$ git clone https://github.com/lcsmota/MetasMinApi.git`

`$ cd MetasMinApi/`

`$ dotnet restore`

`$ dotnet run`

**Server listenning at  [https://localhost:7168](https://localhost:7168)**
#

## 📫  Routes
#### Retorna todas as metas

```http
  GET https://localhost:7168/metas/
```

#### Retorna uma meta

```http
  GET https://localhost:7168/metas/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID da meta que você quer visualizar|

#### Retorna todas as metas concluídas

```http
  GET https://localhost:7168/metas/concluidas
```

#
#### Cria uma meta

```http
  POST https://localhost:7168/metas/
```
**body:**
```
{
   "nome": "Testando Minimal Api",
   "isConcluida": true
}
```

**response:**
```
{
   "id": 1,
   "nome": "Testando Minimal Api",
   "isConcluida": true
}
```
#
#### Atualiza uma meta

```http
  PUT https://localhost:7168/metas/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID da meta que você quer atualizar|

**body:**
```
{
   "nome": "Testando Minimal Api",
   "isConcluida": true
}
```

**response:**
```
{
  Status Code (204) - No Content
}
```
#
#### Remove uma meta
```http
  DELETE https://localhost:7168/metas/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID da meta que você quer remover|

**body:**
```
{

}
```

**response:**
```
{
  Status Code (204) - No Content
}
```

#
## 🔨 Tools used

<div>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="80" />
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="80" />
</div>

# 🖥️ Technologies and practices used
- [x] C# 10
- [x] .NET CORE 6
- [x] Minimal API
- [x] In Memory Data Base
- [x] Dependency injection
- [x] POO

# 📖 Features
Registration, Listing, Update and Removal
