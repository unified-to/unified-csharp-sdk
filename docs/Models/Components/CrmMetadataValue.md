# CrmMetadataValue

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
CrmMetadataValue.CreateMapOfAny(/* values here */);
```

### Str

```csharp
CrmMetadataValue.CreateStr(/* values here */);
```

### Number

```csharp
CrmMetadataValue.CreateNumber(/* values here */);
```

### Boolean

```csharp
CrmMetadataValue.CreateBoolean(/* values here */);
```

### ArrayOfCrmMetadataSchemas5

```csharp
CrmMetadataValue.CreateArrayOfCrmMetadataSchemas5(/* values here */);
```
