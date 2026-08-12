# DbType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = DbType.Mongodb;

// Open enum: use .Of() to create instances from custom string values
var custom = DbType.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Mongodb`   | mongodb     |
| `Mysql`     | mysql       |
| `Postgres`  | postgres    |
| `Mssql`     | mssql       |
| `Mariadb`   | mariadb     |
| `Supabase`  | supabase    |
| `Snowflake` | snowflake   |