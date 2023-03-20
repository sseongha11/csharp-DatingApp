# Dating App Project with Dotnet

## 1. Setup

### 1.1 To get information about the available commands and the environment:
```bash
dotnet --info
dotnet -h
```
### 1.2
```bash
dotnet new sln
```

### 1.4
```bash
dotnet new webapi -n API
```

### 1.5
```bash
dotnet sln add API/
```

### 1.6
```bash
dotnet sln list
```

### 1.7 Go to API folder
```bash
dotnet run
```
or
```bash
dotnet run -lp https
```
### 1.8
```bash
dotnet dev-certs https --trust
```
### 1.9
```bash
dotnet restore
```

### 1.10
```bash
dotnet watch run
```
### 1.11
```bash
dotnet watch run
```
## 2. Introduction to Entity Framework
- An Object Relational Mapper (ORM)
- Translates our code into SQL commands that update our tables in the database.
- Features: querying, change tracking, saving, concurrency, transactions, caching, built-in conventions, configurations and migrations

![Entity Framework](images/entity-framework.png)

## 3. Adding Entity Framework to Our Project
 - Visit NuGet
 - Install microsoft.entityframework.sqlite
 - Install microsoft.entityframeworkcore.design

![nuget](images/nuget.png)

## 4. Adding a DbContext Class
- Making API/Data folder
- Making New Class (DataContext.cs)

![db-context-class-1](images/db-context-class-1.png)
![db-context-class-2](images/db-context-class-2.png)

## 5. Creating the Connection String
- You can visit the below webpage.
https://www.nuget.org/packages/dotnet-ef

- You have to change the directory to be inside of the API folder
```shell
dotnet tool list -g 
dotnet tool install --global dotnet-ef --version 7.0.3
dotnet ef
```
```shell
dotnet ef migrations add InitialCreate -o Data/Migrations
```
 - If you face some errors, you can check the error details through 

```shell
dotnet build
```
![connection-string-1](images/connection-string-1.png)
![connection-string-2](images/connection-string-2.png)
![connection-string-3](images/connection-string-3.png)
![connection-string-4](images/connection-string-4.png)
![connection-string-5](images/connection-string-5.png)
![connection-string-6](images/connection-string-6.png)

## 6. Creating the database using Entity Framework Code first migrations

```shell
dotnet ef database -h
dotnet ef database update
```

![create-data-base-1](images/create-database-1.png)
![create-data-base-2](images/create-database-2.png)
![create-data-base-3](images/create-database-3.png)
![create-data-base-4](images/create-database-4.png)

## 7. Adding a new API Controller

- go API/Controllers folder

- create class (UsersController.cs)
![adding-new-api-1](images/adding-new-api-1.png)
![adding-new-api-2](images/adding-new-api-2.png)

- Run API Server Run in API
```shell
dotnet watch run
```
- check https://localhost:7008/api/users
![adding-new-api-3](images/adding-new-api-3.png)

- open POSTMAN and creat workspace in POSTMAN
![adding-new-api-4](images/adding-new-api-4.png)
![adding-new-api-7](images/adding-new-api-7.png)

- we can also check the results in Swagger
![adding-new-api-5](images/adding-new-api-5.png)
![adding-new-api-6](images/adding-new-api-6.png)

# 8. Making our code Asynchronous

- go to API/Controllers/Userscontrollers.cs
- change the code using async and await
![asynchronous-1](images/asynchronous-1.png)

# 9. Saving our code into Source Control

- Install Git
- Go settings - Github
- Settings/Developer settings
- Tokens(classic)- New personl access token (classic)
- check everything
- Generate Token
- "git status" on CLI
- "git init"
- "dotnet new list"
- "dotnet new gitignore"
- add appsettings.json file to .gitignore
  : API/appsettings.json
- "dotnet new globaljson"
- create new repository on Github
- perform the following comamnd on CLI
  ```shell
  echo "# csharp-DatingApp" >> README.md
  git init
  git add README.md
  git commit -m "Finished Section 2"
  git branch
  ```