# AtsMetadataValue

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
AtsMetadataValue.CreateMapOfAny(/* values here */);
```

### Str

```csharp
AtsMetadataValue.CreateStr(/* values here */);
```

### Number

```csharp
AtsMetadataValue.CreateNumber(/* values here */);
```

### Boolean

```csharp
AtsMetadataValue.CreateBoolean(/* values here */);
```

### ArrayOfAtsMetadataSchemas5

```csharp
AtsMetadataValue.CreateArrayOfAtsMetadataSchemas5(/* values here */);
```
