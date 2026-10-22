# CommerceMetadataValue

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
CommerceMetadataValue.CreateMapOfAny(/* values here */);
```

### Str

```csharp
CommerceMetadataValue.CreateStr(/* values here */);
```

### Number

```csharp
CommerceMetadataValue.CreateNumber(/* values here */);
```

### Boolean

```csharp
CommerceMetadataValue.CreateBoolean(/* values here */);
```

### ArrayOfCommerceMetadataSchemas5

```csharp
CommerceMetadataValue.CreateArrayOfCommerceMetadataSchemas5(/* values here */);
```
