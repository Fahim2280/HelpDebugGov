# HelpDebugGov

## Academic Course "Advance .Net" Final Project

### Pre-requisites

* Docker
* .Net 7

### How to run

``` bash
dotnet tool install --global dotnet-ef // Install EF Core CLI
docker compose up // Run Postgres
dotnet ef database update // Create database
```

then,
`dotnet run` or `dotnet watch run`

### Commands / QuickAccess

* `dotnet run` - Run the project
* `dotnet watch run` - Run the project with auto-reload
* `dotnet ef database update` - Update the database
* `dotnet ef migrations add <name>` - Create a new migration
* `dotnet ef migrations remove` - Remove the last migration
* `docker compose up` - Run the database in a docker container
* `docker compose rm -fs && docker compose up` - Reset the database
* `dotnet new webapi -o HelpDebugGov --no-https -f net7.0` - The way this project was created
