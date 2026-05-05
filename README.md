# ASP.NET Core (MVC)

## Basic Setup

### Packages

1. PostgreSQL: Npgsql.EntityFrameworkCore.PostgreSQL
2. Migration Commands: Microsoft.EntityFrameworkCore.Tools
3. Microsoft.EntityFrameworkCore
4. Microsoft.EntityFrameworkCore.Design

### Connection String

```json
"DefaultConnection": "Host=localhost;Port=5432;Database=dbname;Username=un;Password=pswd"
```

### Migrations

Adding Migration to DB: `add-migration AddCategoryToTb`

Update Database: `update-database`



Notes:

1. Up: What changes are going to be applied.
2. Down: If something is wrong in Up, do this.



### Features

### TempData

* `TempData` is a dictionary object that stores data temporarily. 

* Useful for short-lived messages (e.g., alerts, notifications).

* Data persists only until it is read.


