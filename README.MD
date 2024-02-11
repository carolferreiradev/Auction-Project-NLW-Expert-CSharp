# Auction Project - NLW Expert C#

## API

- Concepts of Controllers, Entities, Repositories, and UseCase;
- DB Browser for SQLite for database visualization;
- ORM Entity Framework;
- Unit testing.

![swagger](https://github.com/carolferreiradev/Auction-Project-NLW-Expert-CSharp/blob/main/docs/swagger.png)

### Open DB File
- SQLite Browser - https://sqlitebrowser.org/dl/

### Necessary changes for API execution
- You can find DataBase File in `/api/leilaoDbNLW.db`;
- In `api\src\AuctionProject.API\Program.cs`, change **YOUR_DB_PATH** to the path where your database is located.

``builder.Services.AddDbContext<AuctionProjectDbContext>(options => {
    options.UseSqlite("Data Source=YOUR_DB_PATH");
});``


### Packages installed with NuGet Packages

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- FluentAssertions
- Moq
- Bogus

## WEB - Extra Step

- Under construction

## MOBILE - Extra Step
- Under construction
