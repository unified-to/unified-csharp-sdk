# Value

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
Value.CreateMapOfAny(/* values here */);
```

### Str

```csharp
Value.CreateStr(/* values here */);
```

### Number

```csharp
Value.CreateNumber(/* values here */);
```

### Boolean

```csharp
Value.CreateBoolean(/* values here */);
```

### ArrayOfAccountingMetadata5

```csharp
Value.CreateArrayOfAccountingMetadata5(/* values here */);
```
