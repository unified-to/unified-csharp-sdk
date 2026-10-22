# DatastoreMetadataValue

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
DatastoreMetadataValue.CreateMapOfAny(/* values here */);
```

### Str

```csharp
DatastoreMetadataValue.CreateStr(/* values here */);
```

### Number

```csharp
DatastoreMetadataValue.CreateNumber(/* values here */);
```

### Boolean

```csharp
DatastoreMetadataValue.CreateBoolean(/* values here */);
```

### ArrayOfDatastoreMetadataSchemas5

```csharp
DatastoreMetadataValue.CreateArrayOfDatastoreMetadataSchemas5(/* values here */);
```
