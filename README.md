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

**Server listenning at  [https://localhost:7168/metas](https://localhost:7168/metas)**
#

## 📫  Routes
### Retorna todas as metas

```http
  GET https://localhost:7168/metas
```
⚙️  **Status Code:**
```http
  (200) - OK
```
#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230094525-4630a0b8-9992-48fc-b4c2-2abce9a4bc15.png" />

### Retorna uma meta

```http
  GET https://localhost:7168/metas/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID da meta que você quer visualizar|

⚙️  **Status Code:**
```http
  (200) - OK
  (404) - Not Found
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230095422-2c502d57-8892-47cb-8eaf-1c61369b0705.png" />
<img src="https://user-images.githubusercontent.com/118696036/230095435-7bf668f7-39ed-41a3-9840-65dc82e4e829.png" />

### Retorna todas as metas concluídas

```http
  GET https://localhost:7168/metas/concluidas
```

⚙️  **Status Code:**
```http
  (200) - OK
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230098501-b74e5e2e-2cbe-4944-8072-4f0a460ea594.png" />
<img src="https://user-images.githubusercontent.com/118696036/230098520-9f862a7f-d7f6-4793-b483-d19a81ff7de1.png" />

#
### Cria uma meta

```http
  POST https://localhost:7168/metas
```
📨  **body:**
```
{
   "nome": "Testando Minimal Api",
   "isConcluida": true
}
```

🧾  **response:**
```
{
   "id": 1,
   "nome": "Testando Minimal Api",
   "isConcluida": true
}
```

⚙️  **Status Code:**
```http
  (201) - Created
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230099413-fcc27eaf-7956-4bb2-9ea2-7bf7cfcd381b.png" />

#
### Atualiza uma meta

```http
  PUT https://localhost:7168/metas/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID da meta que você quer atualizar|

📨  **body:**
```
{
   "nome": "Testando Minimal Api",
   "isConcluida": true
}
```

🧾  **response:**

⚙️  **Status Code:**
```http
  (204) - No Content
  (404) - Not Found
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230097013-80fa2d88-d5bf-4c3d-900f-0beaa44338f7.png"/>
<img src="https://user-images.githubusercontent.com/118696036/230095435-7bf668f7-39ed-41a3-9840-65dc82e4e829.png" />

#
#### Remove uma meta
```http
  DELETE https://localhost:7168/metas/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID da meta que você quer remover|

📨  **body:**

🧾  **response:**

⚙️  **Status Code:**
```http
  (204) - No Content
  (404) - Not Found
```

#### 📬  Postman
<img src="https://user-images.githubusercontent.com/118696036/230100518-6e3d0c62-0206-4012-8f68-7619f0d02d07.png" />
<img src="https://user-images.githubusercontent.com/118696036/230095435-7bf668f7-39ed-41a3-9840-65dc82e4e829.png" />


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
