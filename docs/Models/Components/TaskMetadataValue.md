# TaskMetadataValue

The field's value, typed by `format`: DATE as ISO-8601 (`YYYY-MM-DD`, or `YYYY-MM-DDTHH:MM:SSZ` for date-times); NUMBER, PRICE and CURRENCY as a number; BOOLEAN and YES_NO as true/false; MULTIPLE_SELECT as an array of option values; otherwise a string.


## Supported Types

### MapOfAny

```csharp
TaskMetadataValue.CreateMapOfAny(/* values here */);
```

### Str

```csharp
TaskMetadataValue.CreateStr(/* values here */);
```

### Number

```csharp
TaskMetadataValue.CreateNumber(/* values here */);
```

### Boolean

```csharp
TaskMetadataValue.CreateBoolean(/* values here */);
```

### ArrayOfTaskMetadataSchemas5

```csharp
TaskMetadataValue.CreateArrayOfTaskMetadataSchemas5(/* values here */);
```
