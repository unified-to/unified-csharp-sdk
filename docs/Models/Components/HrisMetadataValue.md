# HrisMetadataValue

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
HrisMetadataValue.CreateMapOfAny(/* values here */);
```

### Str

```csharp
HrisMetadataValue.CreateStr(/* values here */);
```

### Number

```csharp
HrisMetadataValue.CreateNumber(/* values here */);
```

### Boolean

```csharp
HrisMetadataValue.CreateBoolean(/* values here */);
```

### ArrayOfHrisMetadataSchemas5

```csharp
HrisMetadataValue.CreateArrayOfHrisMetadataSchemas5(/* values here */);
```
